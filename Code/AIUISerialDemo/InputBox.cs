using System;
using System.Windows.Forms;

namespace Input
{
    /// <summary>
    /// clsInputBox 的摘要说明。
    /// </summary>
    public class InputBox : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox txtData;
        private Button start_btn;
        private Button cancle_btn;
        private System.ComponentModel.Container components = null;

        private InputBox()
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
            this.start_btn = new System.Windows.Forms.Button();
            this.cancle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtData.Location = new System.Drawing.Point(19, 12);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(221, 53);
            this.txtData.TabIndex = 0;
            this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyDown);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(38, 71);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 24);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "开始合成";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // cancle_btn
            // 
            this.cancle_btn.Location = new System.Drawing.Point(144, 71);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(75, 24);
            this.cancle_btn.TabIndex = 2;
            this.cancle_btn.Text = "取消合成";
            this.cancle_btn.UseVisualStyleBackColor = true;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // InputBox
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(262, 101);
            this.ControlBox = false;
            this.Controls.Add(this.cancle_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.txtData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputBox";
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
            InputBox inputbox = new InputBox();
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