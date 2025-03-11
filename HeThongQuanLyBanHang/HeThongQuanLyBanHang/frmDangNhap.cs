using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyBanHang
{
    public partial class frmDangNhap: Form
    {
        // Chuỗi kết nối SQL Server
        string connectionString = "Server=LAPTOPCUAHUY;Database=QuanLyBanHang;Integrated Security=True;";

        public frmDangNhap()
        {
            InitializeComponent();

            // Ẩn mật khẩu bằng dấu *
            txtPassword.PasswordChar = '*'; // Ẩn mật khẩu bằng dấu *

            // Gán sự kiện KeyDown
            txtUsername.KeyDown += TxtUsername_KeyDown;
            txtPassword.KeyDown += TxtPassword_KeyDown;

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbHienThiPasswork_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiPassword.Checked)
                txtPassword.PasswordChar = '\0'; // Hiện mật khẩu
            else
                txtPassword.PasswordChar = '*'; // Ẩn mật khẩu

        }

        // Khi nhấn Enter trong txtusername => Chuyển sang txtpassword
        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn Enter gây tiếng "beep"
                txtPassword.Focus();
            }
        }

        // Khi nhấn Enter trong txtpassword => Thực hiện đăng nhập
        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn Enter gây tiếng "beep"
                btnDangNhap.PerformClick(); // Gọi sự kiện click của nút đăng nhập
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản và mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // ⚠️ Cần mã hóa mật khẩu trước khi lưu vào CSDL

                        int userExists = (int)cmd.ExecuteScalar(); // Kiểm tra xem có tài khoản hợp lệ không

                        if (userExists > 0)
                        {
                            // Đăng nhập thành công
                            this.Hide(); // Ẩn form đăng nhập

                            frmMain main = new frmMain();
                            main.ShowDialog(); // Hiển thị form chính

                            this.Close(); // Đóng form đăng nhập
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnHuyDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
