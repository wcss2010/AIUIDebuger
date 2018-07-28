using System;
using System.Windows.Forms;

namespace Input
{
    /// <summary>
    /// clsInputBox 的摘要说明。
    /// </summary>
    public class CoustomDataInputBox : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtData;
        private Button sendBtn;
        private Button cancle_btn;
        private System.ComponentModel.Container components = null;

        private CoustomDataInputBox()
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.cancle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtData.Location = new System.Drawing.Point(19, 12);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(306, 53);
            this.txtData.TabIndex = 0;
            this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(49, 71);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 24);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "发送";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // cancle_btn
            // 
            this.cancle_btn.Location = new System.Drawing.Point(214, 71);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(75, 24);
            this.cancle_btn.TabIndex = 2;
            this.cancle_btn.Text = "取消";
            this.cancle_btn.UseVisualStyleBackColor = true;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // CoustomDataInputBox
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(337, 101);
            this.ControlBox = false;
            this.Controls.Add(this.cancle_btn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.txtData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CoustomDataInputBox";
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
                txtData.Text = string.Empty;
                this.Close();
            }

        }

        //显示InputBox
        public static string ShowInputBox(string Title, string keyInfo)
        {
            CoustomDataInputBox inputbox = new CoustomDataInputBox();
            inputbox.Text = Title;
            inputbox.ShowDialog();

            return inputbox.txtData.Text;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            txtData.Text = string.Empty;
            this.Close();
        }


    }

}