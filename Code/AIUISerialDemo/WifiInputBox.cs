using System;
using System.Windows.Forms;

namespace Input
{
    /// <summary>
    /// clsInputBox 的摘要说明。
    /// </summary>
    public class WifiInputBox : System.Windows.Forms.Form
    {
        private Button start_btn;
        private Button cancle_btn;
        private TextBox passTv;
        private Label label1;
        private Label label2;
        private TextBox ssidTv;
        private ComboBox encryptBox;
        private Label label3;
        private System.ComponentModel.Container components = null;

        private WifiInputBox()
        {
            InitializeComponent();

            encryptBox.Items.Add("WPA");
            encryptBox.Items.Add("WEP");
            encryptBox.Items.Add("NONE");
            encryptBox.Text = "WPA";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }

            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.start_btn = new System.Windows.Forms.Button();
            this.cancle_btn = new System.Windows.Forms.Button();
            this.passTv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ssidTv = new System.Windows.Forms.TextBox();
            this.encryptBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(26, 112);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 24);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "确认";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // cancle_btn
            // 
            this.cancle_btn.Location = new System.Drawing.Point(130, 112);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(75, 24);
            this.cancle_btn.TabIndex = 6;
            this.cancle_btn.Text = "取消";
            this.cancle_btn.UseVisualStyleBackColor = true;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // passTv
            // 
            this.passTv.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passTv.Location = new System.Drawing.Point(64, 46);
            this.passTv.Multiline = true;
            this.passTv.Name = "passTv";
            this.passTv.Size = new System.Drawing.Size(163, 27);
            this.passTv.TabIndex = 1;
            this.passTv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ssid:";
            // 
            // ssidTv
            // 
            this.ssidTv.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ssidTv.Location = new System.Drawing.Point(64, 13);
            this.ssidTv.Multiline = true;
            this.ssidTv.Name = "ssidTv";
            this.ssidTv.Size = new System.Drawing.Size(163, 27);
            this.ssidTv.TabIndex = 0;
            // 
            // encryptBox
            // 
            this.encryptBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptBox.FormattingEnabled = true;
            this.encryptBox.Location = new System.Drawing.Point(64, 79);
            this.encryptBox.Name = "encryptBox";
            this.encryptBox.Size = new System.Drawing.Size(163, 20);
            this.encryptBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "加密方式:";
            // 
            // WifiInputBox
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(239, 146);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptBox);
            this.Controls.Add(this.ssidTv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancle_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.passTv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WifiInputBox";
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //对键盘进行响应
        private void txtData_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                ssidTv.Text = string.Empty;
                passTv.Text = string.Empty;
                encryptBox.Text = string.Empty;
                this.Close();
            }

        }

        //显示InputBox
        public static string ShowInputBox(string Title, string keyInfo)
        {
            WifiInputBox inputbox = new WifiInputBox();
            inputbox.Text = Title;
            inputbox.ShowDialog();

            return inputbox.ssidTv.Text.Trim() + "|" + inputbox.passTv.Text.Trim() + "|" + inputbox.encryptBox.Text.Trim();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            ssidTv.Text = string.Empty;
            passTv.Text = string.Empty;
            encryptBox.Text = string.Empty;
            this.Close();
        }



    }

}