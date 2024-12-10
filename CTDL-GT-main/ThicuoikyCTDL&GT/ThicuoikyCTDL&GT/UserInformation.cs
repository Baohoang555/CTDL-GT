using System;

namespace ThicuoikyCTDL_GT
{
    public class UserInformation 
    {
        // Thuộc tính của lớp User
        public string Username { get; set; }   // Tên đăng nhập
        public string Password { get; set; }   // Mật khẩu
        public int IdentityNumber { get; set; } // Mã định danh

        // Constructor để khởi tạo đối tượng User
        public UserInformation(string username, string password, int identityNumber)
        {
            Username = username;
            Password = password;
            IdentityNumber = identityNumber;
        }

        // Phương thức để hiển thị thông tin (dùng cho kiểm tra/debug)
        public override string ToString()
        {
            return $"Username: {Username}, Password: {Password}, IdentityNumber: {IdentityNumber}";
        }
    }
}
