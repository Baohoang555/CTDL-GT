using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ThicuoikyCTDL_GT
{

    public partial class HomePageForm : Form
    {
        //public BinarySearchTree UserListBinaryTree = new BinaryTree();

        public HomePageForm()
        {
            InitializeComponent(); // MUST come first!
            this.Load += new System.EventHandler(this.Form1_Load);

            UserInformation data = new UserInformation();
            data.username = "khaihoan.tran";
            data.password = "khaihoan123";
            data.phoneNumber = "0396835632";
            data.fullname = "Tran Khai Hoan";
            data.identifier = "31161020990";

            BinaryTreeManager.Insert(data);

            this.HomePageLoginButton.Click += HomePageLoginButton_Click;
        }
        private void HomePageSignUpButton_Click(object sender, EventArgs e)
        {

            Signup signup = new Signup();
            signup.Show();


        }
        private void HomePageLoginButton_Click(object sender, EventArgs e)
        {
            //BinaryTreeManager.TranverseInOrder(BinaryTreeManager.Root);
            var existingUsername = BinaryTreeManager.Find(UserTextBox.Text);
            //MessageBox.Show("username: " + existingUsername.Data.username + ", password: " + existingUsername.Data.password);

            if (existingUsername != null && existingUsername.Data.password == PWTextBox.Text)
            {
                MessageBox.Show("Đăng nhập thành công.");
                Information informationForm = new Information(existingUsername.Data);
                informationForm.Show();
                this.Hide();
            }
            else { MessageBox.Show("Đăng nhập thất bại."); }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (UserTextBox != null)
            {
                UserTextBox.Text = "Mã định danh của bạn:";
                UserTextBox.ForeColor = System.Drawing.Color.Gray;
                UserTextBox.Enter += txtbInfor_Enter;
                UserTextBox.Leave += txtbInfor_Leave;
                UserTextBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            }
            if (PWTextBox != null)
            {
                PWTextBox.Text = "Nhập mật khẩu của bạn:";
                PWTextBox.ForeColor = System.Drawing.Color.Gray;
                PWTextBox.Enter += txtbPassword_Enter;
                PWTextBox.Leave += txtbPassword_Leave;
                PWTextBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            }
        }

        private void txtbInfor_Enter(object sender, EventArgs e)
        {
            if (UserTextBox.Text == "Mã định danh của bạn:")
            {
                UserTextBox.Text = "";
                UserTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void txtbInfor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserTextBox.Text))
            {
                UserTextBox.Text = "Mã định danh của bạn:";
                UserTextBox.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                UserTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtbInfor_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UserTextBox.Text) &&
                UserTextBox.Text != "Tên người dùng hoặc số điện thoại:")
            {
                UserTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void txtbPassword_Enter(object sender, EventArgs e)
        {
            if (PWTextBox.Text == "Nhập mật khẩu của bạn:")
            {
                PWTextBox.Text = "";
                PWTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PWTextBox.Text))
            {
                PWTextBox.Text = "Nhập mật khẩu của bạn:";
                PWTextBox.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                PWTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PWTextBox.Text) &&
                PWTextBox.Text != "Nhập mật khẩu của bạn:")
            {
                PWTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void pnltbx_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblForgotUsername_Click(object sender, EventArgs e)
        {
            Forgot_Information forgotInformation = new Forgot_Information(this);
            forgotInformation.Show();
            this.Hide();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void HomePageForm_Load_1(object sender, EventArgs e)
        {

        }

        private void HomePageSignupButton_Click_1(object sender, EventArgs e)
        {
            Signup signUp = new Signup();
            signUp.Show();
        }
    }
}