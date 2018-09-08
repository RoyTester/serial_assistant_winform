using System;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace 串口助手
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Icon =new Icon(@"C:\Users\zhong.rui\Desktop\128.ico");
        }
        SerialPort sp = new SerialPort();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] SerialName = SerialPort.GetPortNames();
            
            foreach (string s in SerialName) 
            {
                //添加串口
                cbSerialPortName.Items.Add(s);
                //串口加入默认
                cbSerialPortName.SelectedIndex=0;
            }
            //初始化
            cbBaudRate.SelectedIndex = 0;
            cbDatabits.SelectedIndex = 3;
            cbParity.SelectedIndex = 0;
            cbStop.SelectedIndex = 0;
            rb16Rcv.Checked = true;
            rb16Send.Select();
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataRecevied);
            Control.CheckForIllegalCrossThreadCalls = false;
            textBoxRcv.Text = "  这是一个串口测试工具,仅供指示灯测试使用 "+System.Environment.NewLine+"  故障调试请使用XCOM串口工具"+"\r\n";
            textBoxRcv.Text += "  版本V1.0 "+"\r\n";
            /*
            for (i = 0; i < 30; i++)
            {
                textBoxRcv.Text += "test"+"\r\n";
                
                this.textBoxRcv.Focus();
                this.textBoxRcv.Select(this.textBoxRcv.TextLength, 0);
                this.textBoxRcv.ScrollToCaret();
            }
            */
        }

        void sp_DataRecevied(object sender, SerialDataReceivedEventArgs e)
        {
            if(sp.IsOpen)
            {

                DateTime dt = DateTime.Now;
                textBoxRcv.Text += dt.GetDateTimeFormats('f')[0].ToString() + "\r\n";
                try
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];
                    sp.Read(ReceivedData, 0, ReceivedData.Length);
                    sp.DiscardInBuffer();
                    if (rb16Rcv.Checked)
                    {
                        string strRcv = null;
                        for (int i = 0; i < ReceivedData.Length; i++)
                        {
                            strRcv += ReceivedData[i].ToString("x2");
                       }
                       textBoxRcv.Text += strRcv + "\r\n";
                    }
                    if (rbStrRcv.Checked)
                    {
                        string strRcv = null;
                        for (int i = 0; i < ReceivedData.Length; i++)
                        {
                            strRcv += ((char) Convert.ToInt32(ReceivedData[i]));
                        }
                        textBoxRcv.Text += strRcv + "\r\n";
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "出错");
                    textBoxSend.Text = "";
                }
            }
            else
            {
                MessageBox.Show("打开串口", "错误");
            }

        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                /*
                #region 打开时自动识别串口

                string[] PortName = SerialPort.GetPortNames();

                foreach (string s in PortName)
                {
                    if (cbSerialPortName.SelectedIndex==s.IndexOf(s))
                    {
                        continue;
                    }
                    else
                    {
                        //添加串口
                        cbSerialPortName.Items.Add(s);
                        //串口加入默认
                        cbSerialPortName.SelectedIndex = 0;
                    }
                    
                }

                #endregion 
                */
                try
                {
                    sp.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                    sp.DataBits = Convert.ToInt32(cbDatabits.Text);
                    string SerialName = cbSerialPortName.SelectedItem.ToString();
                    sp.PortName = SerialName;
                    switch (cbStop.Text)
                    {
                        case "1":
                            sp.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            sp.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            sp.StopBits = StopBits.Two;
                            break;
                        default:
                            break;
                    }
                    switch (cbParity.Text)
                    {
                        case "无":
                            sp.Parity = Parity.None;
                            break;
                        case "偶校验":
                            sp.Parity = Parity.Even;
                            break;
                        case "奇校验":
                            sp.Parity = Parity.Odd;
                            break;
                        default:
                            break;
                    }
                    if (sp.IsOpen)
                    {
                        sp.Close();
                    }
                    sp.Open();
                    cbSerialPortName.Enabled = false;
                    cbBaudRate.Enabled = false;
                    cbParity.Enabled = false;
                    cbDatabits.Enabled = false;
                    cbStop.Enabled = false;
                    btnOpenSerial.Text = "关闭";
                }
                
                catch (System.Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message, "error");
                    return;
                }
            
            }
            else
            {
                sp.Close();
                cbSerialPortName.Enabled = true;
                cbStop.Enabled = true;
                cbBaudRate.Enabled = true;
                cbDatabits.Enabled = true;
                cbParity.Enabled = true;
                btnOpenSerial.Text = "打开";

            }
        }

        private void btnClearSend_Click(object sender, EventArgs e)
        {
            textBoxSend.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("请打开串口");
                return;
            }

            #region 发送数据
            string strSend = textBoxSend.Text;

            if (rb16Send.Checked)         //以16进制格式进行发送
            {
                string strBuf = strSend;
                string sendnoNull = strBuf.Trim();      //去掉空格
                string[] sendArray = strBuf.Split(' ');  //以空格分割

                byte[] b = new byte[sendArray.Length];
                //逐个将字符转为16进制字节数据
                for (int i = 0; i < sendArray.Length; i++)
                {
                    b[i] = Convert.ToByte(sendArray[i], 16);
                }

                sp.Write(b, 0, b.Length);
            }
            else              //以字符串格式发送
            {
                sp.WriteLine(textBoxSend.Text);
            }


            #endregion
        }

        private void btnClearRcv_Click(object sender, EventArgs e)
        {
            textBoxRcv.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region 发送验证
        private void textBoxSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb16Send.Checked == true)      //以16进制格式发送数据时，只能输入特定字符
            {
                //正则匹配
                string patten = "[0-9a-fA-F]|\b|0x|0X| "; //“\b”：退格键
                Regex r = new Regex(patten);
                Match m = r.Match(e.KeyChar.ToString());

                if (m.Success)//&&(txtSend.Text.LastIndexOf(" ") != txtSend.Text.Length-1))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Close();
        }

        int i =0;
        /*
        private bool cLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            if (cLB.GetItemChecked(i))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)
            {
                for (i = 0; i < cLB.Items.Count; i++)
                {
                    cLB.SetItemChecked(i, true);
                }
            }
        }

        private void cbRvs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRvs.Checked)
            {
                for (i = 0; i < cLB.Items.Count; i++)
                {
                    if (cLB.GetItemChecked(i))
                    {
                        cLB.SetItemChecked(i, false);
                    }
                    else
                    {
                        cLB.SetItemChecked(i, true);
                    }
                }

            }
        }
        private static byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            string[] parm = new string[16];
            parm[0] = "02 05 05 00 ff 00 8C C5";
            parm[1] = "02 05 05 01 ff 00 DD 05";
            parm[2] = "02 05 05 02 ff 00 2d 05";
            parm[3] = "02 05 05 03 ff 00 7c c5";
            parm[4] = "02 05 05 04 FF 00 CD 04";
            parm[5] = "02 05 05 05 ff 00 9c c4";
            parm[6] = "02 05 05 06 ff 00 6c c4";
            parm[7] = "02 05 05 07 ff 00 3d 04";
            parm[8] = "02 05 05 08 ff 00 0d 07";
            parm[9] = "02 05 05 09 ff 00 5c c7";
            parm[10] = "02 05 05 0a ff 00 ac c7";
            parm[11] = "02 05 05 0b ff 00 fd 07";
            parm[12] = "02 05 05 0c ff 00 4c c6";
            parm[13] = "02 05 05 0d ff 00 1d 06";
            parm[14] = "02 05 05 0e ff 00 ed 06";
            parm[15] = "02 05 05 0f ff 00 bc c6";
            

            if (cLB.CheckedItems.Count == 0)
            {
                MessageBox.Show("请先选中要打开的号码");
            }
            else if(sp.IsOpen)
            {
                for (i = 0; i < cLB.Items.Count; i++)
                {
                        
                    if (cLB.GetItemChecked(i) == true)
                    {
                            
                        byte[] b=strToHexByte(parm[i]);
                        sp.Write(b, 0, b.Length);


                        if (cbTimer.Checked)
                        {
                            
                            if (tbTimer.Text.Length != 0)
                            {
                                int timer = Convert.ToInt32(tbTimer.Text);
                                Thread.Sleep(timer);
                            }
                            else
                            {
                                Thread.Sleep(100);
                            }
                        }
                        else
                        {
                            Thread.Sleep(100);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先打开串口", "错误");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string[] parmc = new string[16];
            parmc[0] = "02 05 05 00 00 00 CD 35";
            parmc[1] = "02 05 05 01 00 00 9C F5";
            parmc[2] = "02 05 05 02 00 00 6c f5";
            parmc[3] = "02 05 05 03 00 00 3d 35";
            parmc[4] = "02 05 05 04 00 00 8c f4";
            parmc[5] = "02 05 05 05 00 00 dd 34";
            parmc[6] = "02 05 05 06 00 00 2d 34";
            parmc[7] = "02 05 05 07 00 00 7c f4";
            parmc[8] = "02 05 05 08 00 00 4c f7";
            parmc[9] = "02 05 05 09 00 00 1d 37";
            parmc[10] = "02 05 05 0a 00 00 ed 37";
            parmc[11] = "02 05 05 0b 00 00 bc f7";
            parmc[12] = "02 05 05 0c 00 00 0d 36";
            parmc[13] = "02 05 05 0d 00 00 5c f6";
            parmc[14] = "02 05 05 0e 00 00 ac f6";
            parmc[15] = "02 05 05 0f 00 00 fd 36";
            if (cLB.CheckedItems.Count == 0)
            {
                MessageBox.Show("请先选中要关闭的号码");
            }
            else if(sp.IsOpen)
            {
                for (i = 0; i < cLB.Items.Count; i++)
                {
                    if (cLB.GetItemChecked(i) == true)
                    {
                        
                        byte[] b = strToHexByte(parmc[i]);
                        sp.Write(b,0,b.Length);

                        if (cbTimer.Checked)
                        {
                            
                            if (tbTimer.Text.Length != 0)
                            {
                                int timer = Convert.ToInt32(tbTimer.Text);
                                Thread.Sleep(timer);
                            }
                            else
                            {
                                Thread.Sleep(100);
                            }
                        }
                        else
                        {
                            Thread.Sleep(100);
                        }
                    }                       
                }
            }
            else
            {
                MessageBox.Show("请先打开串口", "错误");
            }               
        }
    }
}


