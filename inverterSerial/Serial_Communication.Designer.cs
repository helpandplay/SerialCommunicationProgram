
namespace inverterSerial
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.cb_comPort = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cb_baud = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btn_connect_toggle = new System.Windows.Forms.Button();
      this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
      this.rect_connect = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
      this.tb_send1 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btn_Send = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cb_seqSend = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.rb_send_ascii = new System.Windows.Forms.RadioButton();
      this.rb_send_hex = new System.Windows.Forms.RadioButton();
      this.tb_receive = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rb_receive_ascii = new System.Windows.Forms.RadioButton();
      this.rb_receive_hex = new System.Windows.Forms.RadioButton();
      this.btn_receive_refersh = new System.Windows.Forms.Button();
      this.btn_receive = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // serialPort1
      // 
      this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
      // 
      // cb_comPort
      // 
      this.cb_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cb_comPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cb_comPort.FormattingEnabled = true;
      this.cb_comPort.Location = new System.Drawing.Point(90, 7);
      this.cb_comPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cb_comPort.Name = "cb_comPort";
      this.cb_comPort.Size = new System.Drawing.Size(151, 28);
      this.cb_comPort.TabIndex = 0;
      this.cb_comPort.SelectionChangeCommitted += new System.EventHandler(this.OnSelectComPort);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(8, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "COM";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.cb_baud);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.cb_comPort);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.panel1.Size = new System.Drawing.Size(249, 83);
      this.panel1.TabIndex = 2;
      // 
      // cb_baud
      // 
      this.cb_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cb_baud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cb_baud.FormattingEnabled = true;
      this.cb_baud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
      this.cb_baud.Location = new System.Drawing.Point(90, 44);
      this.cb_baud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cb_baud.Name = "cb_baud";
      this.cb_baud.Size = new System.Drawing.Size(151, 28);
      this.cb_baud.TabIndex = 3;
      this.cb_baud.SelectionChangeCommitted += new System.EventHandler(this.OnSelectBaud);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label2.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(8, 47);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "BAUD";
      // 
      // btn_connect_toggle
      // 
      this.btn_connect_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_connect_toggle.Location = new System.Drawing.Point(327, 12);
      this.btn_connect_toggle.Name = "btn_connect_toggle";
      this.btn_connect_toggle.Size = new System.Drawing.Size(91, 32);
      this.btn_connect_toggle.TabIndex = 3;
      this.btn_connect_toggle.Text = "Connect";
      this.btn_connect_toggle.UseVisualStyleBackColor = true;
      this.btn_connect_toggle.Click += new System.EventHandler(this.btn_connect_toggle_Click);
      // 
      // shapeContainer1
      // 
      this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
      this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
      this.shapeContainer1.Name = "shapeContainer1";
      this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rect_connect});
      this.shapeContainer1.Size = new System.Drawing.Size(473, 432);
      this.shapeContainer1.TabIndex = 4;
      this.shapeContainer1.TabStop = false;
      // 
      // rect_connect
      // 
      this.rect_connect.BackColor = System.Drawing.Color.Red;
      this.rect_connect.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
      this.rect_connect.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
      this.rect_connect.Location = new System.Drawing.Point(425, 14);
      this.rect_connect.Name = "rect_connect";
      this.rect_connect.Size = new System.Drawing.Size(34, 28);
      // 
      // tb_send1
      // 
      this.tb_send1.Enabled = false;
      this.tb_send1.Location = new System.Drawing.Point(97, 9);
      this.tb_send1.Name = "tb_send1";
      this.tb_send1.Size = new System.Drawing.Size(233, 27);
      this.tb_send1.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 12);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(88, 20);
      this.label3.TabIndex = 6;
      this.label3.Text = "Send Data";
      // 
      // btn_Send
      // 
      this.btn_Send.BackColor = System.Drawing.Color.LimeGreen;
      this.btn_Send.FlatAppearance.BorderSize = 0;
      this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_Send.Location = new System.Drawing.Point(352, 9);
      this.btn_Send.Name = "btn_Send";
      this.btn_Send.Size = new System.Drawing.Size(86, 27);
      this.btn_Send.TabIndex = 7;
      this.btn_Send.Text = "Send";
      this.btn_Send.UseVisualStyleBackColor = false;
      this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.cb_seqSend);
      this.panel2.Controls.Add(this.groupBox2);
      this.panel2.Controls.Add(this.btn_Send);
      this.panel2.Controls.Add(this.tb_send1);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Location = new System.Drawing.Point(12, 103);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(448, 92);
      this.panel2.TabIndex = 8;
      // 
      // cb_seqSend
      // 
      this.cb_seqSend.AutoSize = true;
      this.cb_seqSend.Location = new System.Drawing.Point(157, 58);
      this.cb_seqSend.Name = "cb_seqSend";
      this.cb_seqSend.Size = new System.Drawing.Size(100, 24);
      this.cb_seqSend.TabIndex = 15;
      this.cb_seqSend.Text = "연속 전송";
      this.cb_seqSend.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rb_send_ascii);
      this.groupBox2.Controls.Add(this.rb_send_hex);
      this.groupBox2.Location = new System.Drawing.Point(7, 37);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(144, 50);
      this.groupBox2.TabIndex = 14;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "send Type";
      // 
      // rb_send_ascii
      // 
      this.rb_send_ascii.AutoSize = true;
      this.rb_send_ascii.Location = new System.Drawing.Point(71, 21);
      this.rb_send_ascii.Name = "rb_send_ascii";
      this.rb_send_ascii.Size = new System.Drawing.Size(65, 24);
      this.rb_send_ascii.TabIndex = 12;
      this.rb_send_ascii.TabStop = true;
      this.rb_send_ascii.Text = "Ascii";
      this.rb_send_ascii.UseVisualStyleBackColor = true;
      this.rb_send_ascii.CheckedChanged += new System.EventHandler(this.rb_send_ascii_CheckedChanged);
      // 
      // rb_send_hex
      // 
      this.rb_send_hex.AutoSize = true;
      this.rb_send_hex.Location = new System.Drawing.Point(5, 21);
      this.rb_send_hex.Name = "rb_send_hex";
      this.rb_send_hex.Size = new System.Drawing.Size(60, 24);
      this.rb_send_hex.TabIndex = 11;
      this.rb_send_hex.TabStop = true;
      this.rb_send_hex.Text = "Hex";
      this.rb_send_hex.UseVisualStyleBackColor = true;
      this.rb_send_hex.CheckedChanged += new System.EventHandler(this.rb_send_hex_CheckedChanged);
      // 
      // tb_receive
      // 
      this.tb_receive.Location = new System.Drawing.Point(3, 33);
      this.tb_receive.Multiline = true;
      this.tb_receive.Name = "tb_receive";
      this.tb_receive.ReadOnly = true;
      this.tb_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tb_receive.Size = new System.Drawing.Size(436, 134);
      this.tb_receive.TabIndex = 9;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(108, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "Receive Data";
      // 
      // panel3
      // 
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.groupBox1);
      this.panel3.Controls.Add(this.btn_receive_refersh);
      this.panel3.Controls.Add(this.btn_receive);
      this.panel3.Controls.Add(this.label4);
      this.panel3.Controls.Add(this.tb_receive);
      this.panel3.Location = new System.Drawing.Point(12, 201);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(448, 223);
      this.panel3.TabIndex = 10;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rb_receive_ascii);
      this.groupBox1.Controls.Add(this.rb_receive_hex);
      this.groupBox1.Location = new System.Drawing.Point(3, 168);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 50);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "receive Type";
      // 
      // rb_receive_ascii
      // 
      this.rb_receive_ascii.AutoSize = true;
      this.rb_receive_ascii.Location = new System.Drawing.Point(71, 21);
      this.rb_receive_ascii.Name = "rb_receive_ascii";
      this.rb_receive_ascii.Size = new System.Drawing.Size(65, 24);
      this.rb_receive_ascii.TabIndex = 12;
      this.rb_receive_ascii.TabStop = true;
      this.rb_receive_ascii.Text = "Ascii";
      this.rb_receive_ascii.UseVisualStyleBackColor = true;
      this.rb_receive_ascii.CheckedChanged += new System.EventHandler(this.rb_ascii_CheckedChanged);
      // 
      // rb_receive_hex
      // 
      this.rb_receive_hex.AutoSize = true;
      this.rb_receive_hex.Location = new System.Drawing.Point(5, 21);
      this.rb_receive_hex.Name = "rb_receive_hex";
      this.rb_receive_hex.Size = new System.Drawing.Size(60, 24);
      this.rb_receive_hex.TabIndex = 11;
      this.rb_receive_hex.TabStop = true;
      this.rb_receive_hex.Text = "Hex";
      this.rb_receive_hex.UseVisualStyleBackColor = true;
      this.rb_receive_hex.CheckedChanged += new System.EventHandler(this.rb_hex_CheckedChanged);
      // 
      // btn_receive_refersh
      // 
      this.btn_receive_refersh.BackColor = System.Drawing.Color.PaleGreen;
      this.btn_receive_refersh.FlatAppearance.BorderSize = 0;
      this.btn_receive_refersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_receive_refersh.Location = new System.Drawing.Point(261, 3);
      this.btn_receive_refersh.Name = "btn_receive_refersh";
      this.btn_receive_refersh.Size = new System.Drawing.Size(86, 27);
      this.btn_receive_refersh.TabIndex = 10;
      this.btn_receive_refersh.Text = "Refresh";
      this.btn_receive_refersh.UseVisualStyleBackColor = false;
      this.btn_receive_refersh.Click += new System.EventHandler(this.btn_receive_refersh_Click);
      // 
      // btn_receive
      // 
      this.btn_receive.BackColor = System.Drawing.Color.LimeGreen;
      this.btn_receive.FlatAppearance.BorderSize = 0;
      this.btn_receive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn_receive.Location = new System.Drawing.Point(353, 3);
      this.btn_receive.Name = "btn_receive";
      this.btn_receive.Size = new System.Drawing.Size(86, 27);
      this.btn_receive.TabIndex = 8;
      this.btn_receive.Text = "Receive";
      this.btn_receive.UseVisualStyleBackColor = false;
      this.btn_receive.Click += new System.EventHandler(this.receive_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Enabled = false;
      this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label5.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(314, 60);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(147, 29);
      this.label5.TabIndex = 11;
      this.label5.Text = "Penguin Corp";
      // 
      // button1
      // 
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(267, 21);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(28, 27);
      this.button1.TabIndex = 12;
      this.button1.Text = "R";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.COM_refresh_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(473, 432);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.btn_connect_toggle);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.shapeContainer1);
      this.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.ShowIcon = false;
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.ComboBox cb_comPort;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ComboBox cb_baud;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btn_connect_toggle;
    private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    private Microsoft.VisualBasic.PowerPacks.RectangleShape rect_connect;
    private System.Windows.Forms.TextBox tb_send1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btn_Send;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox tb_receive;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button btn_receive;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btn_receive_refersh;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rb_receive_ascii;
    private System.Windows.Forms.RadioButton rb_receive_hex;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rb_send_ascii;
    private System.Windows.Forms.RadioButton rb_send_hex;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.CheckBox cb_seqSend;
  }
}

