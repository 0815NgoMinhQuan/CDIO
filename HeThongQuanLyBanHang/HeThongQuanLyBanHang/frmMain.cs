using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongQuanLyBanHang.ĐonHang;
using HeThongQuanLyBanHang.HangHoa;

namespace HeThongQuanLyBanHang
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // xử lí mở form con
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_AD.Controls.Add(childForm);
            panelChildForm_AD.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // xử lí chuyển màu khi click vào button
        private Guna.UI2.WinForms.Guna2Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender is Guna.UI2.WinForms.Guna2Button btn)  // Kiểm tra kiểu đúng
            {
                if (currentButton != btn)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#4169E1");
                    currentButton = btn;
                    currentButton.FillColor = color; // Guna2Button dùng FillColor thay vì BackColor
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control btn in panelMenu.Controls)
            {
                if (btn is Guna.UI2.WinForms.Guna2Button gunaBtn)
                {
                    gunaBtn.FillColor = Color.FromArgb(39, 39, 58);
                    gunaBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmHangHoa());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmDonHang());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
