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
    public partial class frmDangKyTaiKhoan: Form
    {
        // Chuỗi kết nối SQL Server
        string connectionString = "Server=LAPTOPCUAHUY;Database=QuanLyBanHang;Integrated Security=True;";

        public frmDangKyTaiKhoan()
        {
            InitializeComponent();

            // Đặt dấu '*' cho ô nhập mật khẩu
            txtPassword.PasswordChar = '*';
            txtNhapLaiPassword.PasswordChar = '*';

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhapLaiPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkshowpass.Checked;
            txtPassword.PasswordChar = isChecked ? '\0' : '*';
            txtNhapLaiPassword.PasswordChar = isChecked ? '\0' : '*';

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtNhapLaiPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Chưa mã hóa, cần cải thiện

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Xóa nội dung sau khi đăng ký thành công
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtNhapLaiPassword.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng cửa sổ hiện tại
        }
    }
}
