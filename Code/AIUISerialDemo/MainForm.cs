using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Runtime.InteropServices;
using AIUISerials;

namespace AIUIDebuger
{
    public partial class AIUI : Form
    {
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();

        static AIUIConnection comm = null;
        FileHelper fileHelper;
        System.Timers.Timer checkTimer = new System.Timers.Timer();
        string selectedSerial = "";
        string baud = "";
        Boolean smartconfigOn = false;
        bool consoleOn = true;
        bool isStartSave = false;

        public AIUI()
        {
            InitializeComponent();

            baudCombox.Items.Add("9600");
            baudCombox.Items.Add("19200");
            baudCombox.Items.Add("38400");
            baudCombox.Items.Add("57600");
            baudCombox.Items.Add("115200");
            baudCombox.Text = "115200";
            SetTimerParam();
            openBtn.Enabled = true;
            closeBtn.Enabled = false;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (!selectedSerial.Equals(""))
            {
                checkTimer.Enabled = false;
                comm = new AIUIConnection(selectedSerial,int.Parse(baud));
                comm.aiui = this;

                comm.SerialPort.Connect();
                if (comm.SerialPort.IsConnected)
                {
                    comm.SendShake();
                    comm.AIUIConnectionReceivedEvent += comm_AIUIConnectionReceivedEvent;

                    openBtn.Enabled = false;
                    closeBtn.Enabled = true;
                }
            }
            else {
                MessageBox.Show("您没有选择串口", "系统提示");
            }
        }

        void comm_AIUIConnectionReceivedEvent(object sender, AIUIConnectionReceivedEventArgs args)
        {
            if (recSetHex.Checked && !recSetASC.Checked)
            {
                SetRecTextDelegate d = new SetRecTextDelegate(setRecText);
                string result = "";
                foreach (byte b in args.Source)
                {
                    if (b <= 0x0f)
                    {
                        result += "0" + Convert.ToString(b, 16) + " ";
                    }
                    else
                    {
                        result += Convert.ToString(b, 16) + " ";
                    }
                }
                Invoke(d, result);
            }
            else
            {
                string str = System.Text.Encoding.UTF8.GetString(args.Source);
                SetRecTextDelegate d = new SetRecTextDelegate(setRecText);
                Invoke(d, str);
            }
        }

        private delegate void AddSerialDelegate(string s);
        private delegate void ClearSerialDelegate();
        private delegate void SetMessageDelegate(string result);
        private delegate void SetRecTextDelegate(string result);

        private void addSerial(string s) {
            serialList.Items.Add(s);
        }

        private void clearSerial() {
            serialList.Items.Clear();
        }

        private void setRecText(string text) {
            if (recText.Text.Length > 5000)
            {
                recText.Text = "";
            }
            recText.AppendText(text + "\n");
        }

        private void checkSerial(object source, System.Timers.ElapsedEventArgs e)
        {

            AddSerialDelegate d1 = new AddSerialDelegate(addSerial);
            ClearSerialDelegate d2 = new ClearSerialDelegate(clearSerial);
            Invoke(d2);
            foreach (string s in SerialPort.GetPortNames())
            {
                Invoke(d1, s);
            }
        }

        public void SetTimerParam()
        {
            checkTimer.Elapsed += new ElapsedEventHandler(checkSerial);
            checkTimer.Interval = 2000;
            checkTimer.AutoReset = true;//执行一次 false，一直执行true  
            //是否执行System.Timers.Timer.Elapsed事件  
            checkTimer.Enabled = true;  
        }

        private void serialList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSerial = serialList.Text;
        }

        private void baudCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            baud = baudCombox.Text;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (comm != null && comm.SerialPort.IsConnected) {
                comm.SerialPort.Disconnect();
                checkTimer.Enabled = true;
                openBtn.Enabled = true;
                closeBtn.Enabled = false;
            }
        }

        private void AIUI_FormClosing(object sender, FormClosingEventArgs e) {
            System.Environment.Exit(0);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (!sendText.Text.Equals("")) {
                byte[] data;
                if (sendSetHex.Checked && !sendSetASC.Checked)
                {
                    data = Utils.HexStringToByteArray(sendText.Text);
                }
                else {
                    data = System.Text.Encoding.UTF8.GetBytes(sendText.Text);
                }

                if (data != null)
                {
                    comm.SendToCard(data);
                }
                else
                {
                    MessageBox.Show("发送格式出错");
                }                       
            }            
        }

        private void setMessage(string result)
        {
            if (aiuiMsgTv.Text.Length > 5000) {
                aiuiMsgTv.Text = "";
            }
            aiuiMsgTv.AppendText(result + "\n\n");
            aiuiMsgTv.ScrollToCaret();

            if (isStartSave)
            {
                fileHelper.log(result);
            }
        }

        public void SetAIUIMsg(string result)
        {
            SetMessageDelegate d = new SetMessageDelegate(setMessage);
            Invoke(d, result);
        }

        private void query_aiui_state_btn_Click(object sender, EventArgs e)
        {
            comm.SendCmd(CommandConst.QUERY_AIUI_STATE);
        }

        private void query_wifi_state_Click(object sender, EventArgs e)
        {
            comm.SendCmd(CommandConst.QUERY_WIFI_STATE);
        }

        private void clear_rec_btn_Click(object sender, EventArgs e)
        {
            recText.Text = "";
        }

        private void clear_send_btn_Click(object sender, EventArgs e)
        {
            sendText.Text = "";
        }

        private void clear_message_btn_Click(object sender, EventArgs e)
        {
            aiuiMsgTv.Text = "";
        }

        private void start_tts_btn_Click(object sender, EventArgs e)
        {
            string inMsg = Input.InputBox.ShowInputBox("请输入要合成的文本", string.Empty);
            if (inMsg.Trim() != string.Empty)
            {
                comm.SendTTSMessage(inMsg);
            }

        }

        private void wifi_config_btn_Click(object sender, EventArgs e)
        {
            string inMsg = Input.WifiInputBox.ShowInputBox("请输入wifi ssid及密码", string.Empty);
            string[] data = inMsg.Split('|');
            if (data[0].Trim() != string.Empty)
            {
                comm.ConfigWifiMessage(inMsg.Trim());
            }
        }

        private void aiui_configTv_Click(object sender, EventArgs e)
        {
            string inMsg = Input.AIUIConfigInputBox.ShowInputBox("请输入AIUI配置信息", string.Empty);
            string[] data = inMsg.Split('|');
            if (data[0].Trim() != string.Empty && data[1].Trim() != string.Empty)
            {
                comm.SendAIUIConfigMessage(inMsg.Trim());
            }
            
        }

        private void lauchVoiceBtn_Click(object sender, EventArgs e)
        {
            comm.SendLauchVoiceMessage(true);
        }

        private void stopVoiceBtn_Click(object sender, EventArgs e)
        {
            comm.SendLauchVoiceMessage(false);
        }

        private void smartconfigBtn_Click(object sender, EventArgs e)
        {
            if (!smartconfigOn)
            {
                comm.SendSmartConfigMessage(true);
                smartconfigBtn.Text = "停止SmartConfig";
                smartconfigOn = true;
            }
            else {
                comm.SendSmartConfigMessage(false);
                smartconfigBtn.Text = "开启SmartConfig";
                smartconfigOn = false;
            }
        }

        private void resetWakeBtn_Click(object sender, EventArgs e)
        {
            comm.SendWakeUpMessage(true);
        }

        private void wakeUpBtn_Click(object sender, EventArgs e)
        {
            comm.SendWakeUpMessage(false);
        }

        private void consoleBtn_Click(object sender, EventArgs e)
        {
            if (consoleOn)
            {
                FreeConsole();
                consoleOn = !consoleOn;
                consoleBtn.Text = "打开控制台";
            }
            else {
                AllocConsole();
                consoleOn = !consoleOn;
                consoleBtn.Text = "关闭控制台";
            }
        }

        public bool getIsConsoleOn() {
            return consoleOn;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isStartSave)
            {
                saveBtn.Text = "开始保存";
            }
            else {
                string filePath = Application.StartupPath + "\\AIUILog_" + Utils.GetTimeStamp() + ".txt";
                fileHelper = new FileHelper(filePath);
                saveBtn.Text = "停止保存";
            }
            isStartSave = !isStartSave;
        }

        private void clearConsoleBtn_Click(object sender, EventArgs e)
        {
            if (consoleOn) {
                Console.Clear();
            }
        }
        delegate bool GetAutoReplyDelegate();
        private bool getCheckBox() {
            if (autoSendConfigBox.CheckState == CheckState.Checked)
            {
                return true;
            }
            return false;
        }

        public bool getAutoReply() {
            GetAutoReplyDelegate d = new GetAutoReplyDelegate(getCheckBox);
            IAsyncResult result = d.BeginInvoke(null,null);
            return d.EndInvoke(result);
        }

        private void customDataBtn_Click(object sender, EventArgs e)
        {
            string inMsg = Input.CoustomDataInputBox.ShowInputBox("请输入十六进制数据并用空格分开", string.Empty);
            if (inMsg.Trim() != string.Empty)
            {
                byte[] data = Utils.HexStringToByteArray(inMsg.Trim());
                if (data != null)
                {
                    comm.SendCustomMessage(data);
                }
                else {
                    MessageBox.Show("发送格式出错");
                }
                
            }
        }
    }
}
