namespace 串口助手
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbSerialPortName = new System.Windows.Forms.ComboBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDatabits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb16Send = new System.Windows.Forms.RadioButton();
            this.rbStrSend = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbStrRcv = new System.Windows.Forms.RadioButton();
            this.rb16Rcv = new System.Windows.Forms.RadioButton();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBoxRcv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearRcv = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cLB = new System.Windows.Forms.CheckedListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbTimer = new System.Windows.Forms.CheckBox();
            this.tbTimer = new System.Windows.Forms.TextBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.cbRvs = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // cbSerialPortName
            // 
            this.cbSerialPortName.FormattingEnabled = true;
            this.cbSerialPortName.Location = new System.Drawing.Point(103, 15);
            this.cbSerialPortName.Name = "cbSerialPortName";
            this.cbSerialPortName.Size = new System.Drawing.Size(56, 20);
            this.cbSerialPortName.TabIndex = 1;
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(187, 13);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSerial.TabIndex = 2;
            this.btnOpenSerial.Text = "打开";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDatabits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbStop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // cbDatabits
            // 
            this.cbDatabits.FormattingEnabled = true;
            this.cbDatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDatabits.Location = new System.Drawing.Point(190, 75);
            this.cbDatabits.Name = "cbDatabits";
            this.cbDatabits.Size = new System.Drawing.Size(56, 20);
            this.cbDatabits.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据位";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "偶校验",
            "奇校验"});
            this.cbParity.Location = new System.Drawing.Point(65, 75);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(56, 20);
            this.cbParity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "校验位";
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(190, 32);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(56, 20);
            this.cbStop.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "停止位";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(65, 32);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(56, 20);
            this.cbBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb16Send);
            this.groupBox2.Controls.Add(this.rbStrSend);
            this.groupBox2.Location = new System.Drawing.Point(35, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送格式";
            // 
            // rb16Send
            // 
            this.rb16Send.AutoSize = true;
            this.rb16Send.Location = new System.Drawing.Point(6, 20);
            this.rb16Send.Name = "rb16Send";
            this.rb16Send.Size = new System.Drawing.Size(59, 16);
            this.rb16Send.TabIndex = 0;
            this.rb16Send.TabStop = true;
            this.rb16Send.Text = "16进制";
            this.rb16Send.UseVisualStyleBackColor = true;
            // 
            // rbStrSend
            // 
            this.rbStrSend.AutoSize = true;
            this.rbStrSend.Location = new System.Drawing.Point(65, 20);
            this.rbStrSend.Name = "rbStrSend";
            this.rbStrSend.Size = new System.Drawing.Size(59, 16);
            this.rbStrSend.TabIndex = 1;
            this.rbStrSend.TabStop = true;
            this.rbStrSend.Text = "字符串";
            this.rbStrSend.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbStrRcv);
            this.groupBox3.Controls.Add(this.rb16Rcv);
            this.groupBox3.Location = new System.Drawing.Point(168, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 51);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收格式";
            // 
            // rbStrRcv
            // 
            this.rbStrRcv.AutoSize = true;
            this.rbStrRcv.Location = new System.Drawing.Point(66, 20);
            this.rbStrRcv.Name = "rbStrRcv";
            this.rbStrRcv.Size = new System.Drawing.Size(59, 16);
            this.rbStrRcv.TabIndex = 1;
            this.rbStrRcv.TabStop = true;
            this.rbStrRcv.Text = "字符串";
            this.rbStrRcv.UseVisualStyleBackColor = true;
            // 
            // rb16Rcv
            // 
            this.rb16Rcv.AutoSize = true;
            this.rb16Rcv.Location = new System.Drawing.Point(6, 20);
            this.rb16Rcv.Name = "rb16Rcv";
            this.rb16Rcv.Size = new System.Drawing.Size(59, 16);
            this.rb16Rcv.TabIndex = 0;
            this.rb16Rcv.TabStop = true;
            this.rb16Rcv.Text = "16进制";
            this.rb16Rcv.UseVisualStyleBackColor = true;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(36, 252);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(248, 80);
            this.textBoxSend.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "发送区";
            // 
            // btnClearSend
            // 
            this.btnClearSend.Location = new System.Drawing.Point(136, 338);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(75, 23);
            this.btnClearSend.TabIndex = 8;
            this.btnClearSend.Text = "清空";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(209, 338);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBoxRcv
            // 
            this.textBoxRcv.Location = new System.Drawing.Point(296, 41);
            this.textBoxRcv.Multiline = true;
            this.textBoxRcv.Name = "textBoxRcv";
            this.textBoxRcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRcv.Size = new System.Drawing.Size(226, 291);
            this.textBoxRcv.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "接收区";
            // 
            // btnClearRcv
            // 
            this.btnClearRcv.Location = new System.Drawing.Point(375, 338);
            this.btnClearRcv.Name = "btnClearRcv";
            this.btnClearRcv.Size = new System.Drawing.Size(75, 23);
            this.btnClearRcv.TabIndex = 12;
            this.btnClearRcv.Text = "清空";
            this.btnClearRcv.UseVisualStyleBackColor = true;
            this.btnClearRcv.Click += new System.EventHandler(this.btnClearRcv_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(447, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cLB
            // 
            this.cLB.FormattingEnabled = true;
            this.cLB.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "B1",
            "B2",
            "B3",
            "B4",
            "C1",
            "C2",
            "C3",
            "C4",
            "D1",
            "D2",
            "D3",
            "D4"});
            this.cLB.Location = new System.Drawing.Point(555, 41);
            this.cLB.Name = "cLB";
            this.cLB.Size = new System.Drawing.Size(50, 260);
            this.cLB.TabIndex = 14;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(636, 201);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(636, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbTimer
            // 
            this.cbTimer.AutoSize = true;
            this.cbTimer.Location = new System.Drawing.Point(636, 130);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(72, 16);
            this.cbTimer.TabIndex = 17;
            this.cbTimer.Text = "定时发送";
            this.cbTimer.UseVisualStyleBackColor = true;
            // 
            // tbTimer
            // 
            this.tbTimer.Location = new System.Drawing.Point(636, 153);
            this.tbTimer.Name = "tbTimer";
            this.tbTimer.Size = new System.Drawing.Size(100, 21);
            this.tbTimer.TabIndex = 18;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(636, 41);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(48, 16);
            this.cbAll.TabIndex = 19;
            this.cbAll.Text = "全选";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // cbRvs
            // 
            this.cbRvs.AutoSize = true;
            this.cbRvs.Location = new System.Drawing.Point(636, 77);
            this.cbRvs.Name = "cbRvs";
            this.cbRvs.Size = new System.Drawing.Size(48, 16);
            this.cbRvs.TabIndex = 20;
            this.cbRvs.Text = "反选";
            this.cbRvs.UseVisualStyleBackColor = true;
            this.cbRvs.CheckedChanged += new System.EventHandler(this.cbRvs_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(528, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 314);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "指示灯控制区";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 378);
            this.Controls.Add(this.cbRvs);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.tbTimer);
            this.Controls.Add(this.cbTimer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cLB);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearRcv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRcv);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClearSend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.cbSerialPortName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "串口助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSerialPortName;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDatabits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb16Send;
        private System.Windows.Forms.RadioButton rbStrSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbStrRcv;
        private System.Windows.Forms.RadioButton rb16Rcv;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearRcv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckedListBox cLB;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbTimer;
        private System.Windows.Forms.TextBox tbTimer;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.CheckBox cbRvs;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

