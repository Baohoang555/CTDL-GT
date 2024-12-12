namespace ThicuoikyCTDL_GT
{
    partial class HomePageForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnltbx = new System.Windows.Forms.Panel();
            this.HomePageSignupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PWTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbForgotUserName = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.HomePageLoginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnltbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 452);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnltbx);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 443);
            this.panel2.TabIndex = 0;
            // 
            // pnltbx
            // 
            this.pnltbx.Controls.Add(this.HomePageSignupButton);
            this.pnltbx.Controls.Add(this.label1);
            this.pnltbx.Controls.Add(this.label4);
            this.pnltbx.Controls.Add(this.label3);
            this.pnltbx.Controls.Add(this.PWTextBox);
            this.pnltbx.Controls.Add(this.label2);
            this.pnltbx.Controls.Add(this.lbForgotUserName);
            this.pnltbx.Controls.Add(this.UserTextBox);
            this.pnltbx.Controls.Add(this.HomePageLoginButton);
            this.pnltbx.Location = new System.Drawing.Point(3, 3);
            this.pnltbx.Name = "pnltbx";
            this.pnltbx.Size = new System.Drawing.Size(706, 437);
            this.pnltbx.TabIndex = 4;
            this.pnltbx.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltbx_Paint);
            // 
            // HomePageSignupButton
            // 
            this.HomePageSignupButton.Location = new System.Drawing.Point(560, 378);
            this.HomePageSignupButton.Name = "HomePageSignupButton";
            this.HomePageSignupButton.Size = new System.Drawing.Size(123, 43);
            this.HomePageSignupButton.TabIndex = 7;
            this.HomePageSignupButton.Text = "Đăng kí";
            this.HomePageSignupButton.UseVisualStyleBackColor = true;
            this.HomePageSignupButton.Click += new System.EventHandler(this.HomePageSignupButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiếp tục với định danh điện tử";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tài khoản được quản lý và xác thực trên ứng\r\ndụng định danh điện tử quốc gia (VNe" +
    "ID), do \r\nBộ Công an phát triển.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sử dụng tài khoản định danh điện tử của bạn ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PWTextBox
            // 
            this.PWTextBox.Location = new System.Drawing.Point(20, 184);
            this.PWTextBox.Multiline = true;
            this.PWTextBox.Name = "PWTextBox";
            this.PWTextBox.Size = new System.Drawing.Size(586, 50);
            this.PWTextBox.TabIndex = 3;
            this.PWTextBox.TextChanged += new System.EventHandler(this.txtbPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐỊNH DANH ĐIỆN TỬ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbForgotUserName
            // 
            this.lbForgotUserName.AutoSize = true;
            this.lbForgotUserName.Location = new System.Drawing.Point(16, 248);
            this.lbForgotUserName.Name = "lbForgotUserName";
            this.lbForgotUserName.Size = new System.Drawing.Size(164, 16);
            this.lbForgotUserName.TabIndex = 2;
            this.lbForgotUserName.Text = "Bạn quên tên người dùng ?";
            this.lbForgotUserName.Click += new System.EventHandler(this.lblForgotUsername_Click);
            // 
            // UserTextBox
            // 
            this.UserTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UserTextBox.Location = new System.Drawing.Point(19, 124);
            this.UserTextBox.Multiline = true;
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(586, 54);
            this.UserTextBox.TabIndex = 1;
            this.UserTextBox.TextChanged += new System.EventHandler(this.txtbInfor_TextChanged);
            // 
            // HomePageLoginButton
            // 
            this.HomePageLoginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.HomePageLoginButton.Location = new System.Drawing.Point(429, 377);
            this.HomePageLoginButton.Name = "HomePageLoginButton";
            this.HomePageLoginButton.Size = new System.Drawing.Size(125, 44);
            this.HomePageLoginButton.TabIndex = 0;
            this.HomePageLoginButton.Text = "Đăng nhập ";
            this.HomePageLoginButton.UseVisualStyleBackColor = true;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 469);
            this.Controls.Add(this.panel1);
            this.Name = "HomePageForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomePageForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnltbx.ResumeLayout(false);
            this.pnltbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnltbx;
        private System.Windows.Forms.Button HomePageLoginButton;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label lbForgotUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PWTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button HomePageSignupButton;
    }
}
