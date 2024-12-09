namespace ThicuoikyCTDL_GT
{
    partial class Signup
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
            this.HomePageSignupButton = new System.Windows.Forms.Button();
            this.SignUpPagePignUpButton = new System.Windows.Forms.TextBox();
            this.SUPageUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RetryPassWordTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RetryPassWordTB);
            this.panel1.Controls.Add(this.HomePageSignupButton);
            this.panel1.Controls.Add(this.SignUpPagePignUpButton);
            this.panel1.Controls.Add(this.SUPageUsernameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HomePageSignupButton
            // 
            this.HomePageSignupButton.Location = new System.Drawing.Point(491, 286);
            this.HomePageSignupButton.Name = "HomePageSignupButton";
            this.HomePageSignupButton.Size = new System.Drawing.Size(123, 43);
            this.HomePageSignupButton.TabIndex = 10;
            this.HomePageSignupButton.Text = "Đăng kí";
            this.HomePageSignupButton.UseVisualStyleBackColor = true;
            // 
            // SignUpPagePignUpButton
            // 
            this.SignUpPagePignUpButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPagePignUpButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SignUpPagePignUpButton.Location = new System.Drawing.Point(33, 166);
            this.SignUpPagePignUpButton.Multiline = true;
            this.SignUpPagePignUpButton.Name = "SignUpPagePignUpButton";
            this.SignUpPagePignUpButton.Size = new System.Drawing.Size(581, 54);
            this.SignUpPagePignUpButton.TabIndex = 9;
            // 
            // SUPageUsernameTextBox
            // 
            this.SUPageUsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPageUsernameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SUPageUsernameTextBox.Location = new System.Drawing.Point(33, 106);
            this.SUPageUsernameTextBox.Multiline = true;
            this.SUPageUsernameTextBox.Name = "SUPageUsernameTextBox";
            this.SUPageUsernameTextBox.Size = new System.Drawing.Size(581, 54);
            this.SUPageUsernameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tài khoản được quản lý và xác thực trên ứng\r\ndụng định danh điện tử quốc gia (VNe" +
    "ID), do \r\nBộ Công an phát triển.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ĐỊNH DANH ĐIỆN TỬ";
            // 
            // RetryPassWordTB
            // 
            this.RetryPassWordTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryPassWordTB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RetryPassWordTB.Location = new System.Drawing.Point(33, 226);
            this.RetryPassWordTB.Multiline = true;
            this.RetryPassWordTB.Name = "RetryPassWordTB";
            this.RetryPassWordTB.Size = new System.Drawing.Size(581, 54);
            this.RetryPassWordTB.TabIndex = 11;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 410);
            this.Controls.Add(this.panel1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SignUpPagePignUpButton;
        private System.Windows.Forms.TextBox SUPageUsernameTextBox;
        private System.Windows.Forms.Button HomePageSignupButton;
        private System.Windows.Forms.TextBox RetryPassWordTB;
    }
}