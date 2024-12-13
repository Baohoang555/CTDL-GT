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
            UserInformation data1 = new UserInformation();
            data.username = "hoangbao.vu";
            data.password = "vubao123";
            data.phoneNumber = "0987569874";
            data.fullname = "Vu Hoang Bao";
            data.identifier = "31231022882";

            BinaryTreeManager.Insert(data1);

            UserInformation data2 = new UserInformation();
            data2.username = "nguyenvan.a";
            data2.password = "nguyena123";
            data2.phoneNumber = "0123456789";
            data2.fullname = "Nguyen Van A";
            data2.identifier = "31161020991";
            BinaryTreeManager.Insert(data2);

            UserInformation data3 = new UserInformation();
            data3.username = "tranthib.b";
            data3.password = "tranb123";
            data3.phoneNumber = "0123456790";
            data3.fullname = "Tran Thi B";
            data3.identifier = "31161020992";
            BinaryTreeManager.Insert(data3);

            UserInformation data4 = new UserInformation();
            data4.username = "phamcuong.c";
            data4.password = "phamc123";
            data4.phoneNumber = "0123456791";
            data4.fullname = "Pham Cuong C";
            data4.identifier = "31161020993";
            BinaryTreeManager.Insert(data4);

            UserInformation data5 = new UserInformation();
            data5.username = "dangduy.d";
            data5.password = "dangd123";
            data5.phoneNumber = "0123456792";
            data5.fullname = "Dang Duy D";
            data5.identifier = "31161020994";
            BinaryTreeManager.Insert(data5);

            UserInformation data6 = new UserInformation();
            data6.username = "lethi.e";
            data6.password = "lee123";
            data6.phoneNumber = "0123456793";
            data6.fullname = "Le Thi E";
            data6.identifier = "31161020995";
            BinaryTreeManager.Insert(data6);

            UserInformation data7 = new UserInformation();
            data7.username = "vohieu.f";
            data7.password = "vof123";
            data7.phoneNumber = "0123456794";
            data7.fullname = "Vo Hieu F";
            data7.identifier = "31161020996";
            BinaryTreeManager.Insert(data7);

            UserInformation data8 = new UserInformation();
            data8.username = "buitien.g";
            data8.password = "buitien123";
            data8.phoneNumber = "0123456795";
            data8.fullname = "Bui Tien G";
            data8.identifier = "31161020997";
            BinaryTreeManager.Insert(data8);

            UserInformation data9 = new UserInformation();
            data9.username = "dohoang.h";
            data9.password = "dohoang123";
            data9.phoneNumber = "0123456796";
            data9.fullname = "Do Hoang H";
            data9.identifier = "31161020998";
            BinaryTreeManager.Insert(data9);

            UserInformation data10 = new UserInformation();
            data10.username = "hoangminh.i";
            data10.password = "hoangi123";
            data10.phoneNumber = "0123456797";
            data10.fullname = "Hoang Minh I";
            data10.identifier = "31161020999";
            BinaryTreeManager.Insert(data10);

            UserInformation data11 = new UserInformation();
            data11.username = "ngoclan.j";
            data11.password = "ngocj123";
            data11.phoneNumber = "0123456798";
            data11.fullname = "Ngoc Lan J";
            data11.identifier = "31161021000";
            BinaryTreeManager.Insert(data11);

            UserInformation data12 = new UserInformation();
            data12.username = "quangtrung.k";
            data12.password = "quangk123";
            data12.phoneNumber = "0123456799";
            data12.fullname = "Quang Trung K";
            data12.identifier = "31161021001";
            BinaryTreeManager.Insert(data12);

            UserInformation data13 = new UserInformation();
            data13.username = "minhphuc.l";
            data13.password = "minhl123";
            data13.phoneNumber = "0123456800";
            data13.fullname = "Minh Phuc L";
            data13.identifier = "31161021002";
            BinaryTreeManager.Insert(data13);

            UserInformation data14 = new UserInformation();
            data14.username = "thanhhoa.m";
            data14.password = "thanhm123";
            data14.phoneNumber = "0123456801";
            data14.fullname = "Thanh Hoa M";
            data14.identifier = "31161021003";
            BinaryTreeManager.Insert(data14);

            UserInformation data15 = new UserInformation();
            data15.username = "quanghieu.n";
            data15.password = "quangn123";
            data15.phoneNumber = "0123456802";
            data15.fullname = "Quang Hieu N";
            data15.identifier = "31161021004";
            BinaryTreeManager.Insert(data15);

            UserInformation data16 = new UserInformation();
            data16.username = "xuanthao.o";
            data16.password = "xuano123";
            data16.phoneNumber = "0123456803";
            data16.fullname = "Xuan Thao O";
            data16.identifier = "31161021005";
            BinaryTreeManager.Insert(data16);

            UserInformation data17 = new UserInformation();
            data17.username = "trucanh.p";
            data17.password = "trucp123";
            data17.phoneNumber = "0123456804";
            data17.fullname = "Truc Anh P";
            data17.identifier = "31161021006";
            BinaryTreeManager.Insert(data17);

            UserInformation data18 = new UserInformation();
            data18.username = "kimngan.q";
            data18.password = "kimq123";
            data18.phoneNumber = "0123456805";
            data18.fullname = "Kim Ngan Q";
            data18.identifier = "31161021007";
            BinaryTreeManager.Insert(data18);

            UserInformation data19 = new UserInformation();
            data19.username = "thanhdat.r";
            data19.password = "thanhr123";
            data19.phoneNumber = "0123456806";
            data19.fullname = "Thanh Dat R";
            data19.identifier = "31161021008";
            BinaryTreeManager.Insert(data19);

            UserInformation data20 = new UserInformation();
            data20.username = "anhtu.s";
            data20.password = "anhtus123";
            data20.phoneNumber = "0123456807";
            data20.fullname = "Anh Tu S";
            data20.identifier = "31161021009";
            BinaryTreeManager.Insert(data20);

            UserInformation data21 = new UserInformation();
            data21.username = "minhnhut.t";
            data21.password = "minht123";
            data21.phoneNumber = "0123456808";
            data21.fullname = "Minh Nhut T";
            data21.identifier = "31161021010";
            BinaryTreeManager.Insert(data21);


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
                UserTextBox.Text = "Nhập username của bạn:";
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
            if (UserTextBox.Text == "Nhập username của bạn:")
            {
                UserTextBox.Text = "";
                UserTextBox.ForeColor = System.Drawing.Color.Black;
            }
        }


        private void txtbInfor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserTextBox.Text))
            {
                UserTextBox.Text = "Nhập username của bạn:";
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