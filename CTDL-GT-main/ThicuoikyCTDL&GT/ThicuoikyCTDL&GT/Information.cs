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
    public partial class Information : Form
    {
        private UserInformation _data;
        public Information(UserInformation data)
        {
            _data = data;

            InitializeComponent();
            this.FullNameTxtBox.Text = data.fullname;
            this.PhoneNumberTxtBox.Text = data.phoneNumber;
            this.IdentifierTxtBox.Text = data.identifier;
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fullName = this.FullNameTxtBox.Text;
            string PhoneNumber = this.PhoneNumberTxtBox.Text;
            string Identifier = this.IdentifierTxtBox.Text;

            UserInformation updating = new UserInformation();

            updating.username = this._data.username;
            updating.password = this._data.password;
            updating.fullname = fullName;
            updating.phoneNumber = PhoneNumber; 
            updating.identifier = Identifier;

            bool updated = BinaryTreeManager.Update(updating);

            if (updated) {
                MessageBox.Show("Chỉnh sửa thành công");
            } else
            {
                MessageBox.Show("Chỉnh sửa thất bại");
            }
        }
    }
}
