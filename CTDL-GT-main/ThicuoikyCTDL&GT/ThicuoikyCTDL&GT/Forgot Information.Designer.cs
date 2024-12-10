namespace ThicuoikyCTDL_GT
{
    partial class Forgot_Information
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
            this.txtbIdentityNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnFindUsername = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbIdentityNumber
            // 
            this.txtbIdentityNumber.Location = new System.Drawing.Point(18, 3);
            this.txtbIdentityNumber.Multiline = true;
            this.txtbIdentityNumber.Name = "txtbIdentityNumber";
            this.txtbIdentityNumber.Size = new System.Drawing.Size(356, 60);
            this.txtbIdentityNumber.TabIndex = 0;
            this.txtbIdentityNumber.TextChanged += new System.EventHandler(this.txtbIdentifyNumber_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 199);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbPass);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.btnFindUsername);
            this.panel2.Controls.Add(this.txtbIdentityNumber);
            this.panel2.Location = new System.Drawing.Point(10, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 183);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtbPass
            // 
            this.txtbPass.Location = new System.Drawing.Point(18, 69);
            this.txtbPass.Multiline = true;
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(356, 60);
            this.txtbPass.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(380, 69);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 56);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Quay lại ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 148);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(106, 16);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Tên người dùng: ";
            // 
            // btnFindUsername
            // 
            this.btnFindUsername.Location = new System.Drawing.Point(380, 3);
            this.btnFindUsername.Name = "btnFindUsername";
            this.btnFindUsername.Size = new System.Drawing.Size(146, 60);
            this.btnFindUsername.TabIndex = 1;
            this.btnFindUsername.Text = "Tìm kiếm ";
            this.btnFindUsername.UseVisualStyleBackColor = true;
            this.btnFindUsername.Click += new System.EventHandler(this.btnFindUsername_Click);
            // 
            // Forgot_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 212);
            this.Controls.Add(this.panel1);
            this.Name = "Forgot_Information";
            this.Text = "Forgot_Information";
            this.Load += new System.EventHandler(this.Forgot_Information_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnFindUsername;
        private System.Windows.Forms.TextBox txtbIdentityNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtbPass;
    }
}