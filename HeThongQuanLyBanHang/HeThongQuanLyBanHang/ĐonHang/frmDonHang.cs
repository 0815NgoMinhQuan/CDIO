using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyBanHang.ĐonHang
{
    public partial class frmDonHang: Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }

        DataTable tblDH;
        Class.donhang Obj_DH = new Class.donhang();
        private static bool mode_find_DH = false;

        private void ResetValues_DH() // reset giá trị cho các mục 
        {
            if (!mode_find_DH)
                cboThangBan.Text = "";

            txtMaDonHang.Text = "";
            txtMaHang.Text = "";
            txtMaDienThoai.Text = "";
            txtMaKhachHang.Text = "";
            txtMaNhanVien.Text = "";

            dtpNgayBan.CustomFormat = "dd-MM-yyyy";
            dtpNgayBan.Value = DateTime.Now;

            txtTongTien.Text = "";
            txtSoLuongBan.Text = "";
            txtGiaBan.Text = "";

            btnHuy.Enabled = false;
            btnXoa.Enabled = false;
            btnXemChiTiet.Enabled = false;
            txtMaDonHang.Enabled = false;
        }
        private void getData_fromTable_DH() // lấy dữ liệu từ bảng
        {
            Obj_DH.set_madh(dgv_DH.CurrentRow.Cells["MADH"].Value.ToString());
            Obj_DH.set_mahang(dgv_DH.CurrentRow.Cells["MAHANG"].Value.ToString());
            Obj_DH.set_madt(dgv_DH.CurrentRow.Cells["MADT"].Value.ToString());
            Obj_DH.set_makh(dgv_DH.CurrentRow.Cells["MAKH"].Value.ToString());
            Obj_DH.set_manv(dgv_DH.CurrentRow.Cells["MANV"].Value.ToString());
            Obj_DH.set_ngayban(dgv_DH.CurrentRow.Cells["NGAYBAN"].Value.ToString());
            Obj_DH.set_soluong(dgv_DH.CurrentRow.Cells["SOLUONG"].Value.ToString());
            Obj_DH.set_tongtien(dgv_DH.CurrentRow.Cells["TONGTIEN"].Value.ToString());
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues_DH();

            // nếu đang ở chế độ tìm kiếm
            if (mode_find_DH)
            {
                LoadData_DonHang();
                mode_find_DH = false;
            }
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            // set giá trị cho comboBox
            for (int i = 1; i <= 12; i++)
                cboThangBan.Items.Add(i.ToString());

            ResetValues_DH();
            LoadData_DonHang();
        }
        private void LoadData_DonHang() // tải dữ liệu vào DataGridView
        {
            string sql = "SELECT DH.MADH, DH.MAHANG, DH.MADT, DH.MAKH, DH.MANV, DH.NGAYBAN, DT.GIABAN, DH.SOLUONG, DH.TONGTIEN " +
                "FROM DONHANG DH, DIENTHOAI DT " +
                "WHERE DH.MADT = DT.MADT";
            tblDH = Class.Functions.GetDataToTable(sql);
            dgv_DH.DataSource = tblDH;

            // set Font cho tên cột
            dgv_DH.Font = new Font("Time New Roman", 13);
            dgv_DH.Columns[0].HeaderText = "Mã Đơn Hàng";
            dgv_DH.Columns[1].HeaderText = "Mã Hãng";
            dgv_DH.Columns[2].HeaderText = "Mã Điện Thoại";
            dgv_DH.Columns[3].HeaderText = "Mã Khách Hàng";
            dgv_DH.Columns[4].HeaderText = "Mã NHân Viên";
            dgv_DH.Columns[5].HeaderText = "Ngày Bán";
            dgv_DH.Columns[6].HeaderText = "Giá Bán";
            dgv_DH.Columns[7].HeaderText = "Số Lượng Bán";
            dgv_DH.Columns[8].HeaderText = "Tổng Tiền";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_DH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_DH.Columns[0].Width = 150;
            dgv_DH.Columns[1].Width = 110;
            dgv_DH.Columns[2].Width = 160;
            dgv_DH.Columns[3].Width = 170;
            dgv_DH.Columns[4].Width = 160;
            dgv_DH.Columns[5].Width = 120;
            dgv_DH.Columns[6].Width = 120;
            dgv_DH.Columns[7].Width = 150;
            dgv_DH.Columns[8].Width = 150;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_DH.AllowUserToAddRows = false;
            dgv_DH.EditMode = DataGridViewEditMode.EditProgrammatically;

            if (mode_find_DH)
                cboThangBan.Text = "";
        }
        private void loadData_txtBox()
        {
            txtMaDonHang.Text = dgv_DH.CurrentRow.Cells["MADH"].Value.ToString();
            txtMaHang.Text = dgv_DH.CurrentRow.Cells["MAHANG"].Value.ToString();
            txtMaDienThoai.Text = dgv_DH.CurrentRow.Cells["MADT"].Value.ToString();
            txtMaKhachHang.Text = dgv_DH.CurrentRow.Cells["MAKH"].Value.ToString();
            txtMaNhanVien.Text = dgv_DH.CurrentRow.Cells["MANV"].Value.ToString();
            dtpNgayBan.Text = dgv_DH.CurrentRow.Cells["NGAYBAN"].Value.ToString();
            txtGiaBan.Text = dgv_DH.CurrentRow.Cells["GIABAN"].Value.ToString();
            txtSoLuongBan.Text = dgv_DH.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txtTongTien.Text = dgv_DH.CurrentRow.Cells["TONGTIEN"].Value.ToString();

            // set giá trị cho tháng bán
            string sql = "SELECT MONTH(NGAYBAN) " +
                "FROM DONHANG " +
                "WHERE MADH = '" + dgv_DH.CurrentRow.Cells["MADH"].Value.ToString() + "' ";
            cboThangBan.Text = Class.Functions.GetFieldValues(sql);
        }

        private void dgv_DH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu không có dữ liệu
            if (tblDH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // set giá trị cho các txtBox
            getData_fromTable_DH();
            txtMaDonHang.Text = Obj_DH.get_madh();
            txtMaHang.Text = Obj_DH.get_mahang();
            txtMaDienThoai.Text = Obj_DH.get_madt();
            txtMaKhachHang.Text = Obj_DH.get_makh();
            txtMaNhanVien.Text = Obj_DH.get_manv();
            dtpNgayBan.Text = Obj_DH.get_ngayban();
            txtGiaBan.Text = dgv_DH.CurrentRow.Cells["GIABAN"].Value.ToString();
            txtSoLuongBan.Text = Obj_DH.get_soluong();
            txtTongTien.Text = Obj_DH.get_tongtien();

            // set giá trị cho tháng bán
            string sql = "SELECT MONTH(NGAYBAN) " +
                "FROM DONHANG " +
                "WHERE MADH = '" + dgv_DH.CurrentRow.Cells["MADH"].Value.ToString() + "' ";
            cboThangBan.Text = Class.Functions.GetFieldValues(sql);

            // xử lí enable các nút      
            btnXoa.Enabled = true;
            btnXemChiTiet.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            // load form chi tiết đơn hàng lên
            frmChiTietDonHang ChiTietDH = new frmChiTietDonHang();
            ChiTietDH.StartPosition = FormStartPosition.CenterParent;
            ChiTietDH.madh_CTDH = txtMaDonHang.Text.Trim().ToString();
            ChiTietDH.ShowDialog();

            // nếu có cập nhật thì load lại dữ liệu vào dataGridView
            if (ChiTietDH.was_modify_CTDH)
            {
                ChiTietDH.was_modify_CTDH = false;

                LoadData_DonHang();
                loadData_txtBox();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmChiTietDonHang ChiTietDH = new frmChiTietDonHang();
            ChiTietDH.StartPosition = FormStartPosition.CenterParent;
            ChiTietDH.is_them_DH = true;
            ChiTietDH.ShowDialog();

            // nếu có thêm thì load lại dữ liệu vào dataGridView
            if (ChiTietDH.was_modify_CTDH)
            {
                ChiTietDH.was_modify_CTDH = false;
                LoadData_DonHang();
                ResetValues_DH();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // hỏi người dùng có chắc chắn xóa không ?
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // thực hiện câu lệnh sql xóa
                string sql = "DELETE " +
                    "DONHANG " +
                    "WHERE MADH = '" + txtMaDonHang.Text + "'";
                Class.Functions.RunSQL(sql);

                // tải dữ liệu lên dataGridView
                if (mode_find_DH)
                    setDaTa_FindMode_DH();
                else
                {
                    LoadData_DonHang();
                    ResetValues_DH();
                }
            }
        }
        private void setDaTa_FindMode_DH() //tải dữ liệu đã tìm được vào dataGridView
        {
            // xử lí câu lệnh sql
            string sql = "SELECT DH.MADH, DH.MAHANG, DH.MADT, DH.MAKH, DH.MANV, DH.NGAYBAN, DT.GIABAN, DH.SOLUONG, DH.TONGTIEN " +
                "FROM DONHANG DH, DIENTHOAI DT " +
                "WHERE DH.MADT = DT.MADT " +
                "AND MONTH(NGAYBAN) = '" + cboThangBan.Text.Trim().ToString() + "'";
            tblDH = Class.Functions.GetDataToTable(sql);

            // tải dữ liệu lên dataGridView
            dgv_DH.DataSource = tblDH;

            // reset giá trị cho các mục trừ mục tên hãng điện thoại,xử lí enable các nút       
            ResetValues_DH();
            btnHuy.Enabled = true;
        }

        private void tabPage_donhang_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn làm mới dữ liệu?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetValues_DH();
                cboThangBan.Items.Clear();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            mode_find_DH = true;

            // TH nếu chưa chọn tháng
            if (cboThangBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH đã chọn tháng     
            setDaTa_FindMode_DH();

            // nếu tìm ko ra dữ liệu 
            if (tblDH.Rows.Count == 0)
                MessageBox.Show("Không có đơn hàng trong tháng " + cboThangBan.Text.Trim().ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
