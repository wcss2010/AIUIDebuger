namespace AIUIDebuger
{
    partial class AIUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIUI));
            this.openBtn = new System.Windows.Forms.Button();
            this.serialList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.baudCombox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recText = new System.Windows.Forms.TextBox();
            this.sendText = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.query_aiui_state_btn = new System.Windows.Forms.Button();
            this.aiuiMsgTv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customDataBtn = new System.Windows.Forms.Button();
            this.wakeUpBtn = new System.Windows.Forms.Button();
            this.resetWakeBtn = new System.Windows.Forms.Button();
            this.smartconfigBtn = new System.Windows.Forms.Button();
            this.stopVoiceBtn = new System.Windows.Forms.Button();
            this.lauchVoiceBtn = new System.Windows.Forms.Button();
            this.aiui_configTv = new System.Windows.Forms.Button();
            this.wifi_config_btn = new System.Windows.Forms.Button();
            this.start_tts_btn = new System.Windows.Forms.Button();
            this.wifi_query_btn = new System.Windows.Forms.Button();
            this.clear_rec_btn = new System.Windows.Forms.Button();
            this.clear_send_btn = new System.Windows.Forms.Button();
            this.clear_message_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.recSetHex = new System.Windows.Forms.RadioButton();
            this.recSetASC = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.autoSendConfigBox = new System.Windows.Forms.CheckBox();
            this.sendSetHex = new System.Windows.Forms.RadioButton();
            this.sendSetASC = new System.Windows.Forms.RadioButton();
            this.consoleBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clearConsoleBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(16, 90);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "打开";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // serialList
            // 
            this.serialList.FormattingEnabled = true;
            this.serialList.Location = new System.Drawing.Point(63, 20);
            this.serialList.Name = "serialList";
            this.serialList.Size = new System.Drawing.Size(121, 20);
            this.serialList.TabIndex = 1;
            this.serialList.SelectedIndexChanged += new System.EventHandler(this.serialList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeBtn);
            this.groupBox1.Controls.Add(this.baudCombox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.serialList);
            this.groupBox1.Controls.Add(this.openBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(109, 90);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "关闭";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // baudCombox
            // 
            this.baudCombox.FormattingEnabled = true;
            this.baudCombox.Location = new System.Drawing.Point(63, 53);
            this.baudCombox.Name = "baudCombox";
            this.baudCombox.Size = new System.Drawing.Size(121, 20);
            this.baudCombox.TabIndex = 4;
            this.baudCombox.SelectedIndexChanged += new System.EventHandler(this.baudCombox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "串  口";
            // 
            // recText
            // 
            this.recText.Location = new System.Drawing.Point(229, 228);
            this.recText.Multiline = true;
            this.recText.Name = "recText";
            this.recText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recText.Size = new System.Drawing.Size(434, 125);
            this.recText.TabIndex = 3;
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(229, 359);
            this.sendText.Multiline = true;
            this.sendText.Name = "sendText";
            this.sendText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendText.Size = new System.Drawing.Size(434, 90);
            this.sendText.TabIndex = 4;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(559, 462);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(104, 29);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "发送数据";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // query_aiui_state_btn
            // 
            this.query_aiui_state_btn.Location = new System.Drawing.Point(109, 55);
            this.query_aiui_state_btn.Name = "query_aiui_state_btn";
            this.query_aiui_state_btn.Size = new System.Drawing.Size(85, 29);
            this.query_aiui_state_btn.TabIndex = 6;
            this.query_aiui_state_btn.Text = "唤醒状态查询";
            this.query_aiui_state_btn.UseVisualStyleBackColor = true;
            this.query_aiui_state_btn.Click += new System.EventHandler(this.query_aiui_state_btn_Click);
            // 
            // aiuiMsgTv
            // 
            this.aiuiMsgTv.Location = new System.Drawing.Point(229, 12);
            this.aiuiMsgTv.Multiline = true;
            this.aiuiMsgTv.Name = "aiuiMsgTv";
            this.aiuiMsgTv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aiuiMsgTv.Size = new System.Drawing.Size(434, 172);
            this.aiuiMsgTv.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customDataBtn);
            this.groupBox2.Controls.Add(this.wakeUpBtn);
            this.groupBox2.Controls.Add(this.resetWakeBtn);
            this.groupBox2.Controls.Add(this.smartconfigBtn);
            this.groupBox2.Controls.Add(this.stopVoiceBtn);
            this.groupBox2.Controls.Add(this.lauchVoiceBtn);
            this.groupBox2.Controls.Add(this.aiui_configTv);
            this.groupBox2.Controls.Add(this.wifi_config_btn);
            this.groupBox2.Controls.Add(this.start_tts_btn);
            this.groupBox2.Controls.Add(this.wifi_query_btn);
            this.groupBox2.Controls.Add(this.query_aiui_state_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 228);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "常用命令";
            // 
            // customDataBtn
            // 
            this.customDataBtn.Location = new System.Drawing.Point(109, 158);
            this.customDataBtn.Name = "customDataBtn";
            this.customDataBtn.Size = new System.Drawing.Size(85, 29);
            this.customDataBtn.TabIndex = 20;
            this.customDataBtn.Text = "自定义数据";
            this.customDataBtn.UseVisualStyleBackColor = true;
            this.customDataBtn.Click += new System.EventHandler(this.customDataBtn_Click);
            // 
            // wakeUpBtn
            // 
            this.wakeUpBtn.Location = new System.Drawing.Point(109, 123);
            this.wakeUpBtn.Name = "wakeUpBtn";
            this.wakeUpBtn.Size = new System.Drawing.Size(85, 29);
            this.wakeUpBtn.TabIndex = 19;
            this.wakeUpBtn.Text = "手动唤醒";
            this.wakeUpBtn.UseVisualStyleBackColor = true;
            this.wakeUpBtn.Click += new System.EventHandler(this.wakeUpBtn_Click);
            // 
            // resetWakeBtn
            // 
            this.resetWakeBtn.Location = new System.Drawing.Point(6, 125);
            this.resetWakeBtn.Name = "resetWakeBtn";
            this.resetWakeBtn.Size = new System.Drawing.Size(85, 29);
            this.resetWakeBtn.TabIndex = 18;
            this.resetWakeBtn.Text = "重置唤醒";
            this.resetWakeBtn.UseVisualStyleBackColor = true;
            this.resetWakeBtn.Click += new System.EventHandler(this.resetWakeBtn_Click);
            // 
            // smartconfigBtn
            // 
            this.smartconfigBtn.Location = new System.Drawing.Point(6, 193);
            this.smartconfigBtn.Name = "smartconfigBtn";
            this.smartconfigBtn.Size = new System.Drawing.Size(188, 29);
            this.smartconfigBtn.TabIndex = 17;
            this.smartconfigBtn.Text = "开启SmartConfig";
            this.smartconfigBtn.UseVisualStyleBackColor = true;
            this.smartconfigBtn.Click += new System.EventHandler(this.smartconfigBtn_Click);
            // 
            // stopVoiceBtn
            // 
            this.stopVoiceBtn.Location = new System.Drawing.Point(109, 90);
            this.stopVoiceBtn.Name = "stopVoiceBtn";
            this.stopVoiceBtn.Size = new System.Drawing.Size(85, 29);
            this.stopVoiceBtn.TabIndex = 16;
            this.stopVoiceBtn.Text = "关闭声音播放";
            this.stopVoiceBtn.UseVisualStyleBackColor = true;
            this.stopVoiceBtn.Click += new System.EventHandler(this.stopVoiceBtn_Click);
            // 
            // lauchVoiceBtn
            // 
            this.lauchVoiceBtn.Location = new System.Drawing.Point(6, 90);
            this.lauchVoiceBtn.Name = "lauchVoiceBtn";
            this.lauchVoiceBtn.Size = new System.Drawing.Size(85, 29);
            this.lauchVoiceBtn.TabIndex = 15;
            this.lauchVoiceBtn.Text = "开启声音播放";
            this.lauchVoiceBtn.UseVisualStyleBackColor = true;
            this.lauchVoiceBtn.Click += new System.EventHandler(this.lauchVoiceBtn_Click);
            // 
            // aiui_configTv
            // 
            this.aiui_configTv.Location = new System.Drawing.Point(109, 20);
            this.aiui_configTv.Name = "aiui_configTv";
            this.aiui_configTv.Size = new System.Drawing.Size(85, 29);
            this.aiui_configTv.TabIndex = 14;
            this.aiui_configTv.Text = "AIUI配置";
            this.aiui_configTv.UseVisualStyleBackColor = true;
            this.aiui_configTv.Click += new System.EventHandler(this.aiui_configTv_Click);
            // 
            // wifi_config_btn
            // 
            this.wifi_config_btn.Location = new System.Drawing.Point(6, 20);
            this.wifi_config_btn.Name = "wifi_config_btn";
            this.wifi_config_btn.Size = new System.Drawing.Size(85, 29);
            this.wifi_config_btn.TabIndex = 13;
            this.wifi_config_btn.Text = "WIFI配置";
            this.wifi_config_btn.UseVisualStyleBackColor = true;
            this.wifi_config_btn.Click += new System.EventHandler(this.wifi_config_btn_Click);
            // 
            // start_tts_btn
            // 
            this.start_tts_btn.Location = new System.Drawing.Point(6, 160);
            this.start_tts_btn.Name = "start_tts_btn";
            this.start_tts_btn.Size = new System.Drawing.Size(85, 29);
            this.start_tts_btn.TabIndex = 9;
            this.start_tts_btn.Text = "文本合成";
            this.start_tts_btn.UseVisualStyleBackColor = true;
            this.start_tts_btn.Click += new System.EventHandler(this.start_tts_btn_Click);
            // 
            // wifi_query_btn
            // 
            this.wifi_query_btn.Location = new System.Drawing.Point(6, 55);
            this.wifi_query_btn.Name = "wifi_query_btn";
            this.wifi_query_btn.Size = new System.Drawing.Size(85, 29);
            this.wifi_query_btn.TabIndex = 8;
            this.wifi_query_btn.Text = "WIFI状态查询";
            this.wifi_query_btn.UseVisualStyleBackColor = true;
            this.wifi_query_btn.Click += new System.EventHandler(this.query_wifi_state_Click);
            // 
            // clear_rec_btn
            // 
            this.clear_rec_btn.Location = new System.Drawing.Point(339, 462);
            this.clear_rec_btn.Name = "clear_rec_btn";
            this.clear_rec_btn.Size = new System.Drawing.Size(104, 29);
            this.clear_rec_btn.TabIndex = 9;
            this.clear_rec_btn.Text = "清空接收数据";
            this.clear_rec_btn.UseVisualStyleBackColor = true;
            this.clear_rec_btn.Click += new System.EventHandler(this.clear_rec_btn_Click);
            // 
            // clear_send_btn
            // 
            this.clear_send_btn.Location = new System.Drawing.Point(449, 462);
            this.clear_send_btn.Name = "clear_send_btn";
            this.clear_send_btn.Size = new System.Drawing.Size(104, 29);
            this.clear_send_btn.TabIndex = 10;
            this.clear_send_btn.Text = "清空发送";
            this.clear_send_btn.UseVisualStyleBackColor = true;
            this.clear_send_btn.Click += new System.EventHandler(this.clear_send_btn_Click);
            // 
            // clear_message_btn
            // 
            this.clear_message_btn.Location = new System.Drawing.Point(229, 462);
            this.clear_message_btn.Name = "clear_message_btn";
            this.clear_message_btn.Size = new System.Drawing.Size(104, 29);
            this.clear_message_btn.TabIndex = 12;
            this.clear_message_btn.Text = "清空接收消息";
            this.clear_message_btn.UseVisualStyleBackColor = true;
            this.clear_message_btn.Click += new System.EventHandler(this.clear_message_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.recSetHex);
            this.groupBox3.Controls.Add(this.recSetASC);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 46);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收设置";
            // 
            // recSetHex
            // 
            this.recSetHex.AutoSize = true;
            this.recSetHex.Checked = true;
            this.recSetHex.Location = new System.Drawing.Point(109, 20);
            this.recSetHex.Name = "recSetHex";
            this.recSetHex.Size = new System.Drawing.Size(41, 16);
            this.recSetHex.TabIndex = 1;
            this.recSetHex.TabStop = true;
            this.recSetHex.Text = "Hex";
            this.recSetHex.UseVisualStyleBackColor = true;
            // 
            // recSetASC
            // 
            this.recSetASC.AutoSize = true;
            this.recSetASC.Location = new System.Drawing.Point(16, 21);
            this.recSetASC.Name = "recSetASC";
            this.recSetASC.Size = new System.Drawing.Size(53, 16);
            this.recSetASC.TabIndex = 0;
            this.recSetASC.Text = "ASCII";
            this.recSetASC.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.autoSendConfigBox);
            this.groupBox4.Controls.Add(this.sendSetHex);
            this.groupBox4.Controls.Add(this.sendSetASC);
            this.groupBox4.Location = new System.Drawing.Point(12, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 67);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送设置";
            // 
            // autoSendConfigBox
            // 
            this.autoSendConfigBox.AutoSize = true;
            this.autoSendConfigBox.Checked = true;
            this.autoSendConfigBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSendConfigBox.Location = new System.Drawing.Point(16, 43);
            this.autoSendConfigBox.Name = "autoSendConfigBox";
            this.autoSendConfigBox.Size = new System.Drawing.Size(120, 16);
            this.autoSendConfigBox.TabIndex = 3;
            this.autoSendConfigBox.Text = "自动回复确认消息";
            this.autoSendConfigBox.UseVisualStyleBackColor = true;
            // 
            // sendSetHex
            // 
            this.sendSetHex.AutoSize = true;
            this.sendSetHex.Checked = true;
            this.sendSetHex.Location = new System.Drawing.Point(109, 20);
            this.sendSetHex.Name = "sendSetHex";
            this.sendSetHex.Size = new System.Drawing.Size(41, 16);
            this.sendSetHex.TabIndex = 2;
            this.sendSetHex.TabStop = true;
            this.sendSetHex.Text = "Hex";
            this.sendSetHex.UseVisualStyleBackColor = true;
            // 
            // sendSetASC
            // 
            this.sendSetASC.AutoSize = true;
            this.sendSetASC.Location = new System.Drawing.Point(16, 20);
            this.sendSetASC.Name = "sendSetASC";
            this.sendSetASC.Size = new System.Drawing.Size(53, 16);
            this.sendSetASC.TabIndex = 1;
            this.sendSetASC.Text = "ASCII";
            this.sendSetASC.UseVisualStyleBackColor = true;
            // 
            // consoleBtn
            // 
            this.consoleBtn.Location = new System.Drawing.Point(242, 193);
            this.consoleBtn.Name = "consoleBtn";
            this.consoleBtn.Size = new System.Drawing.Size(118, 29);
            this.consoleBtn.TabIndex = 18;
            this.consoleBtn.Text = "关闭控制台";
            this.consoleBtn.UseVisualStyleBackColor = true;
            this.consoleBtn.Click += new System.EventHandler(this.consoleBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(535, 193);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(118, 29);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "开始保存";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearConsoleBtn
            // 
            this.clearConsoleBtn.Location = new System.Drawing.Point(388, 193);
            this.clearConsoleBtn.Name = "clearConsoleBtn";
            this.clearConsoleBtn.Size = new System.Drawing.Size(118, 29);
            this.clearConsoleBtn.TabIndex = 20;
            this.clearConsoleBtn.Text = "清空控制台";
            this.clearConsoleBtn.UseVisualStyleBackColor = true;
            this.clearConsoleBtn.Click += new System.EventHandler(this.clearConsoleBtn_Click);
            // 
            // AIUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 509);
            this.Controls.Add(this.clearConsoleBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.consoleBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clear_message_btn);
            this.Controls.Add(this.clear_send_btn);
            this.Controls.Add(this.clear_rec_btn);
            this.Controls.Add(this.aiuiMsgTv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.recText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AIUI";
            this.Text = "AIUI串口调试助手V1.2    by五彩书生    ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AIUI_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.ComboBox serialList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox baudCombox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recText;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button query_aiui_state_btn;
        private System.Windows.Forms.TextBox aiuiMsgTv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button wifi_query_btn;
        private System.Windows.Forms.Button clear_rec_btn;
        private System.Windows.Forms.Button clear_send_btn;
        private System.Windows.Forms.Button clear_message_btn;
        private System.Windows.Forms.Button start_tts_btn;
        private System.Windows.Forms.Button wifi_config_btn;
        private System.Windows.Forms.Button aiui_configTv;
        private System.Windows.Forms.Button stopVoiceBtn;
        private System.Windows.Forms.Button lauchVoiceBtn;
        private System.Windows.Forms.Button smartconfigBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton recSetHex;
        private System.Windows.Forms.RadioButton recSetASC;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton sendSetHex;
        private System.Windows.Forms.RadioButton sendSetASC;
        private System.Windows.Forms.Button wakeUpBtn;
        private System.Windows.Forms.Button resetWakeBtn;
        private System.Windows.Forms.Button consoleBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearConsoleBtn;
        private System.Windows.Forms.CheckBox autoSendConfigBox;
        private System.Windows.Forms.Button customDataBtn;
    }
}

