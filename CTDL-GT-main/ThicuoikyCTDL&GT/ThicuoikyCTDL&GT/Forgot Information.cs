﻿using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThicuoikyCTDL_GT
{
    public partial class Forgot_Information : Form
    {
     
        private HomePageForm _form1;

        public Forgot_Information(HomePageForm form1)
        {
            InitializeComponent();
            _form1 = form1; // Lưu tham chiếu đến Form1
            this.Load += new EventHandler(Forgot_Information_Load);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePageForm form1 = new HomePageForm();
            _form1.Show(); 
            this.Close();  
        }


        // Dữ liệu mẫu: danh sách mã định danh và username tương ứng
        private (int id, string username)[] userData = new (int, string)[]
        {
            (101, "user1"),
            (102, "user2"),
            (103, "user3"),
            (104, "user4"),
            (105, "user5")
        };
        private void Forgot_Information_Load(object sender, EventArgs e)
        {
            if (txtbIdentityNumber != null)
            {
                txtbIdentityNumber.Text = "Mã định danh của bạn:";
                txtbIdentityNumber.ForeColor = System.Drawing.Color.Gray;
                txtbIdentityNumber.Enter += txtbIdentifyNumber_Enter;
                txtbIdentityNumber.Leave += txtbIdentifyNumber_Leave;
                txtbIdentityNumber.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtbIdentityNumber.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtbIdentifyNumber_Enter(object sender, EventArgs e)
        {
            if (txtbIdentityNumber.Text == "Mã định danh của bạn:")
            {
                txtbIdentityNumber.Text = "";
                txtbIdentityNumber.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtbIdentifyNumber_Leave(object sender, EventArgs e)
        {

        }

        private void btnFindUsername_Click(object sender, EventArgs e)
        {
            int identityNumber;
            if (int.TryParse(txtbIdentityNumber.Text, out identityNumber))
            {
                string username = BinarySearchUsername(userData, identityNumber);
                if (!string.IsNullOrEmpty(username))
                {
                    lblResult.Text = $"Username của bạn là: {username}";
                }
                else
                {
                    lblResult.Text = "Không tìm thấy mã định danh!";
                }
            }
            else
            {
                lblResult.Text = "Vui lòng nhập mã định danh hợp lệ.";
            }
        }

        // Hàm tìm kiếm nhị phân
        private string BinarySearchUsername((int id, string username)[] data, int targetId)
        {
            int left = 0, right = data.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (data[mid].id == targetId)
                {
                    return data[mid].username;
                }
                else if (data[mid].id < targetId)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null; // Không tìm thấy
        }

        private void Forgot_Information_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
