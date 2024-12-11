using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThicuoikyCTDL_GT
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignUpComplete_Click(object sender, EventArgs e)
        {
            //Add input validation
            if (string.IsNullOrWhiteSpace(SUPageUsernameTextBox.Text) ||
               string.IsNullOrWhiteSpace(SignUpPagePassWordButton.Text) ||
               string.IsNullOrWhiteSpace(RetrySignUpPagePassWordButton.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SignUpPagePassWordButton.Text != RetrySignUpPagePassWordButton.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Get the main form (HomePageForm) instance
            //HomePageForm homePageForm = (HomePageForm)Application.OpenForms["HomePageForm"];
            //add user data to the binary tree
            NodeData data = new NodeData();
            data.username = SUPageUsernameTextBox.Text;
            data.password = SignUpPagePassWordButton.Text;

            BinaryTreeManager.Insert(data);
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SUPageUsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
