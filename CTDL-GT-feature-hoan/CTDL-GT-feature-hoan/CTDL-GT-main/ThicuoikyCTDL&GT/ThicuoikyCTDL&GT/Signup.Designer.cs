﻿namespace ThicuoikyCTDL_GT
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
            this.RetrySignUpPagePassWordButton = new System.Windows.Forms.TextBox();
            this.btnSignUpComplete = new System.Windows.Forms.Button();
            this.SignUpPagePassWordButton = new System.Windows.Forms.TextBox();
            this.SUPageUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RetrySignUpPagePassWordButton);
            this.panel1.Controls.Add(this.btnSignUpComplete);
            this.panel1.Controls.Add(this.SignUpPagePassWordButton);
            this.panel1.Controls.Add(this.SUPageUsernameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 406);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RetrySignUpPagePassWordButton
            // 
            this.RetrySignUpPagePassWordButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetrySignUpPagePassWordButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RetrySignUpPagePassWordButton.Location = new System.Drawing.Point(192, 226);
            this.RetrySignUpPagePassWordButton.Multiline = true;
            this.RetrySignUpPagePassWordButton.Name = "RetrySignUpPagePassWordButton";
            this.RetrySignUpPagePassWordButton.Size = new System.Drawing.Size(422, 54);
            this.RetrySignUpPagePassWordButton.TabIndex = 11;
            // 
            // btnSignUpComplete
            // 
            this.btnSignUpComplete.Location = new System.Drawing.Point(491, 286);
            this.btnSignUpComplete.Name = "btnSignUpComplete";
            this.btnSignUpComplete.Size = new System.Drawing.Size(123, 43);
            this.btnSignUpComplete.TabIndex = 10;
            this.btnSignUpComplete.Text = "Hoàn tất đăng kí";
            this.btnSignUpComplete.UseVisualStyleBackColor = true;
            this.btnSignUpComplete.Click += new System.EventHandler(this.btnSignUpComplete_Click);
            // 
            // SignUpPagePassWordButton
            // 
            this.SignUpPagePassWordButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPagePassWordButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SignUpPagePassWordButton.Location = new System.Drawing.Point(192, 166);
            this.SignUpPagePassWordButton.Multiline = true;
            this.SignUpPagePassWordButton.Name = "SignUpPagePassWordButton";
            this.SignUpPagePassWordButton.Size = new System.Drawing.Size(422, 54);
            this.SignUpPagePassWordButton.TabIndex = 9;
            // 
            // SUPageUsernameTextBox
            // 
            this.SUPageUsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPageUsernameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SUPageUsernameTextBox.Location = new System.Drawing.Point(192, 106);
            this.SUPageUsernameTextBox.Multiline = true;
            this.SUPageUsernameTextBox.Name = "SUPageUsernameTextBox";
            this.SUPageUsernameTextBox.Size = new System.Drawing.Size(422, 54);
            this.SUPageUsernameTextBox.TabIndex = 8;
            this.SUPageUsernameTextBox.TextChanged += new System.EventHandler(this.SUPageUsernameTextBox_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập username của bạn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Xác nhận lại mật khẩu:";
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
        private System.Windows.Forms.TextBox SignUpPagePassWordButton;
        private System.Windows.Forms.TextBox SUPageUsernameTextBox;
        private System.Windows.Forms.Button btnSignUpComplete;
        private System.Windows.Forms.TextBox RetrySignUpPagePassWordButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}