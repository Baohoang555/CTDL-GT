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
        private NodeData _data;
        public Information(NodeData data)
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
    }
}
