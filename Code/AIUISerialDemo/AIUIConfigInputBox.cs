using System;
using System.Windows.Forms;

namespace Input
{
    /// <summary>
    /// clsInputBox 的摘要说明。
    /// </summary>
    public class AIUIConfigInputBox : System.Windows.Forms.Form
    {
        private Button start_btn;
        private Button cancle_btn;
        private TextBox keyTv;
        private Label label1;
        private Label label2;
        private TextBox appidTv;
        private Label label3;
        private TextBox sceneTv;
        private CheckBox lauchBox;
        private System.ComponentModel.Container components = null;

        private AIUIConfigInputBox()
        {
            InitializeComponent();

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
            this.keyTv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appidTv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sceneTv = new System.Windows.Forms.TextBox();
            this.lauchBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(184, 114);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 24);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "确认";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // cancle_btn
            // 
            this.cancle_btn.Location = new System.Drawing.Point(265, 114);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(75, 24);
            this.cancle_btn.TabIndex = 6;
            this.cancle_btn.Text = "取消";
            this.cancle_btn.UseVisualStyleBackColor = true;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // keyTv
            // 
            this.keyTv.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyTv.Location = new System.Drawing.Point(64, 46);
            this.keyTv.Multiline = true;
            this.keyTv.Name = "keyTv";
            this.keyTv.Size = new System.Drawing.Size(276, 27);
            this.keyTv.TabIndex = 1;
            this.keyTv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "appid:";
            // 
            // appidTv
            // 
            this.appidTv.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.appidTv.Location = new System.Drawing.Point(64, 13);
            this.appidTv.Multiline = true;
            this.appidTv.Name = "appidTv";
            this.appidTv.Size = new System.Drawing.Size(276, 27);
            this.appidTv.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "scene:";
            // 
            // sceneTv
            // 
            this.sceneTv.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sceneTv.Location = new System.Drawing.Point(64, 79);
            this.sceneTv.Multiline = true;
            this.sceneTv.Name = "sceneTv";
            this.sceneTv.Size = new System.Drawing.Size(276, 27);
            this.sceneTv.TabIndex = 8;
            this.sceneTv.Text = "main";
            // 
            // lauchBox
            // 
            this.lauchBox.AutoSize = true;
            this.lauchBox.Location = new System.Drawing.Point(12, 119);
            this.lauchBox.Name = "lauchBox";
            this.lauchBox.Size = new System.Drawing.Size(132, 16);
            this.lauchBox.TabIndex = 10;
            this.lauchBox.Text = "是否启动AIUI后处理";
            this.lauchBox.UseVisualStyleBackColor = true;
            // 
            // AIUIConfigInputBox
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(352, 146);
            this.ControlBox = false;
            this.Controls.Add(this.lauchBox);
            this.Controls.Add(this.sceneTv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appidTv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancle_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.keyTv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AIUIConfigInputBox";
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
                appidTv.Text = string.Empty;
                keyTv.Text = string.Empty;
                this.Close();
            }

        }

        //显示InputBox
        public static string ShowInputBox(string Title, string keyInfo)
        {
            AIUIConfigInputBox inputbox = new AIUIConfigInputBox();
            inputbox.Text = Title;
            inputbox.ShowDialog();

            return inputbox.appidTv.Text.Trim() + "|" + inputbox.keyTv.Text.Trim() + "|" + inputbox.sceneTv.Text.Trim() + "|" + inputbox.lauchBox.CheckState;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            appidTv.Text = string.Empty;
            keyTv.Text = string.Empty;
            this.Close();
        }

    }

}