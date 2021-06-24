using System;
using System.Drawing;
using System.Windows.Forms;
// serial port library
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace inverterSerial
{
  public partial class Form1 : Form
  {
    bool isConnect = false;
    string receiveType = string.Empty;
    string sendType = string.Empty;
    public Form1()
    {
      InitializeComponent();
    }
    private void LoadComPorts()
    {
      string[] ports = SerialPort.GetPortNames();
      cb_comPort.Items.AddRange(ports);
    }
    private bool checkSelectedComboBox()
    {
      if (cb_comPort.Text == "" || cb_baud.Text == "") return false;
      return true;
    }
    private bool OnConnect() {
      serialPort1.Open();
      if (serialPort1.IsOpen) return true;
      return false;
    }
    private bool OnDisConnect() {
      serialPort1.Close();
      if (!serialPort1.IsOpen) return true;
      return false;
    }
/*    private void getHz()
    {
      int len = Hex.Length;
      if(len == 14)
      {
        string data = Hex.Substring(6, 4);
        int hz = Convert.ToInt32(data, 16);

        double Wreal2 = hz / 100.0;
        textbox.Text = string.Format("{0, 4:N2", Wreal2);
      }
    }*/
    private void GetReceivedData()
    {
      if (receiveType == string.Empty) return;
      int iSize = serialPort1.BytesToRead;

      string data = string.Empty;
      if (iSize == 0) return;
      byte[] buffer = new byte[iSize];
      serialPort1.Read(buffer, 0, iSize);
      foreach(byte bufferData in buffer)
      {
        switch (receiveType) {
          case "Hex":
            data += "" + bufferData.ToString("X2");
            break;
          case "Ascii":
            data += "" + Convert.ToChar(bufferData);
            break;
          default:
            throw new Exception("알 수 없는 타입입니다. type : " + receiveType);
        }
        
      }
      tb_receive.Text += data + '\r' +'\n';
      tb_receive.SelectionStart = tb_receive.TextLength;
      tb_receive.ScrollToCaret();
    }
    private byte[] getConvertHexData(string input)
    {
      byte[] result = new byte[input.Length / 2];
      int cnt = 0;
      for (int i = 1; i < input.Length; i = i + 2)
      {
        string str = input[i - 1].ToString() + input[i].ToString();
        result[cnt++] = Convert.ToByte(str, 16);
      }
      return result;
    }
    private void sendHex (string input)
    {
      try
      {
        byte[] sendData = getConvertHexData(input);
        serialPort1.Write(sendData, 0, sendData.Length);
      }catch(Exception error)
      {
        MessageBox.Show(error.Message);
      }
    }
    private void sendAscii(string input)
    {
      serialPort1.Write(input);
    }
    private void OnSelectComPort(object sender, EventArgs e)
    {
      serialPort1.PortName = cb_comPort.Text;
    }
    private void OnSelectBaud(object sender, EventArgs e)
    {
      serialPort1.BaudRate = int.Parse(cb_baud.Text);
    }
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (serialPort1.IsOpen) serialPort1.Close();
    }
    private void btn_Send_Click(object sender, EventArgs e)
    {
      if (cb_seqSend.Checked)
      {
        timer1.Interval = 1000;
        timer1.Tick += new EventHandler(timer1_Tick);
        timer1.Start();
      }
      else
      {
        timer1.Stop();
        OnSend();
      }
      
    }
    private void receive_Click(object sender, EventArgs e)
    {
      if (!serialPort1.IsOpen) return;
      tb_receive.Text += "\n"+serialPort1.ReadExisting();
    }
    private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      if (!serialPort1.IsOpen) return;
      this.Invoke(new MethodInvoker(delegate { GetReceivedData(); }));
    }
    private void btn_receive_refersh_Click(object sender, EventArgs e)
    {
      tb_receive.Text = "";
    }
    private void rb_hex_CheckedChanged(object sender, EventArgs e)
    {
      receiveType = "Hex";
    }
    private void rb_ascii_CheckedChanged(object sender, EventArgs e)
    {

      receiveType = "Ascii";
    }
    private void rb_send_hex_CheckedChanged(object sender, EventArgs e)
    {
      sendType = "Hex";
    }
    private void rb_send_ascii_CheckedChanged(object sender, EventArgs e)
    {
      sendType = "Ascii";
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      LoadComPorts();

    }
    private void btn_connect_toggle_Click(object sender, EventArgs e)
    {
      if (!checkSelectedComboBox())
      {
        MessageBox.Show("설정을 선택해주세요");
        return;
      }
      if (!isConnect)
      {
        if (!OnConnect()) return;
        tb_send1.Enabled = true;
        btn_Send.Enabled = true;
        btn_receive.Enabled = true;
        btn_connect_toggle.Text = "Disconnect";
        rect_connect.BackColor = Color.Green;
      }
      else
      {
        if (!OnDisConnect()) return;
        tb_send1.Enabled = false;
        btn_Send.Enabled = false;
        btn_receive.Enabled = false;
        btn_connect_toggle.Text = "Connect";
        rect_connect.BackColor = Color.Red;
      }
      isConnect = !isConnect;
    }
    private void COM_refresh_Click(object sender, EventArgs e)
    {
      LoadComPorts();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      OnSend();
    }
    private void OnSend()
    {
      if (!serialPort1.IsOpen) return;
      switch (sendType)
      {
        case "Hex":
          sendHex(tb_send1.Text);
          break;
        case "Ascii":
          sendAscii(tb_send1.Text);
          break;
        default:
          throw new Exception("알 수 없는 전송 타입 : " + receiveType);
          Thread.Sleep(400);
      }

    }
  }
}
