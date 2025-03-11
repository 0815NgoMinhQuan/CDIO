using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyBanHang
{
    public partial class frmChiTietDonHang: Form
    {
        public bool was_modify_CTDH = false;
        public bool is_them_DH = false;
        public string madh_CTDH = "";

        string mahang_CTDH;
        bool noData_nv_CTDH = false;
        bool noData_kh_CTDH = false;
        bool noData_dt_CTDH = false;
        bool update_sldtmuamoi_CTDH = false;

        int sldt_bancu_CTDH = 0;
        int sldt_banmoi_CTDH = 0;
        int sldt_ban_CTDH = 0;
        int sldt_hang_CTDH = 0;
        public frmChiTietDonHang()
        {
            InitializeComponent();
        }

        private void Resetvalues_CTDH() // reset giá trị cho các mục 
        {
            txtMaDonHang_CTHD.Text = "";
            txtMaNhanVien_CTHD.Text = "";
            txtTenNhanVien_CTHD.Text = "";

            dtpNgayBanCTDH.CustomFormat = "dd-MM-yyyy";
            dtpNgayBanCTDH.Value = DateTime.Now;

            txtMaKhachHang_CTHD.Text = "";
            txtTenKhachHang_CTHD.Text = "";
            mtb_sdtkh_CTHD.Text = "";
            txtDiaChiKH_CTHD.Text = "";

            txtHangDienThoai_CTHD.Text = "";
            txtMaDienThoai_CTHD.Text = "";
            txtTenDienThoai_CTHD.Text = "";
            txtSoLuongHang_CTHD.Text = "";

            txtSoLuongBan_CTHD.Text = "";
            txtGiamGia_CTHD.Text = "";
            txtTongTien_CTHD.Text = "";

            btnCapNhat_CTHD.Enabled = true;
            btnQuayLai_CTHD.Enabled = true;
            btnLuu_CTHD.Enabled = false;
            btnHuy_CTHD.Enabled = true;

            txtMaDonHang_CTHD.Enabled = false;
            txtTenNhanVien_CTHD.Enabled = false;
            txtTenKhachHang_CTHD.Enabled = false;
            mtb_sdtkh_CTHD.Enabled = false;
            txtDiaChiKH_CTHD.Enabled = false;
            txtTenDienThoai_CTHD.Enabled = false;
            txtHangDienThoai_CTHD.Enabled = false;
            txtSoLuongHang_CTHD.Enabled = false;

            txtGiamGia_CTHD.Enabled = false;
        }
        private void LoadData_CTDH() // tải dữ liệu cho các TextBox
        {
            DataTable tblCTDH; // table để chứa dữ liệu truy vấn
            btnLuu_CTHD.Enabled = false;

            // set text cho mã đơn hàng
            txtMaDonHang_CTHD.Text = madh_CTDH;

            // set text cho manv, makh, madt, soluong, giamgia, tongtien
            string sql = "SELECT MANV, MAKH, MADT, SOLUONG, GIAMGIA, TONGTIEN " +
                         "FROM DONHANG " +
                         "WHERE MADH = '" + madh_CTDH + "'";
            tblCTDH = Class.Functions.GetDataToTable(sql);

            txtMaNhanVien_CTHD.Text = tblCTDH.Rows[0].Field<string>(0);
            txtMaKhachHang_CTHD.Text = tblCTDH.Rows[0].Field<string>(1);
            txtMaDienThoai_CTHD.Text = tblCTDH.Rows[0].Field<string>(2);
            txtSoLuongBan_CTHD.Text = tblCTDH.Rows[0].Field<Int32>(3).ToString();
            txtGiamGia_CTHD.Text = tblCTDH.Rows[0].Field<Int32>(4).ToString();
            txtTongTien_CTHD.Text = tblCTDH.Rows[0].Field<decimal>(5).ToString();

            // set text cho ngày bán
            sql = "SELECT NGAYBAN FROM DONHANG WHERE MADH = '" + madh_CTDH + "'";
            dtpNgayBanCTDH.CustomFormat = "dd-MM-yyyy";
            dtpNgayBanCTDH.Value = DateTime.Parse(Class.Functions.GetFieldValues(sql));

            // set hình điện thoại
            string linkanh;
            sql = "SELECT DT.ANH " +
                  "FROM DONHANG DH, DIENTHOAI DT " +
                  "WHERE MADH = '" + madh_CTDH + "' " +
                  "AND DH.MADT = DT.MADT";
            linkanh = Class.Functions.GetFieldValues(sql);

            try
            {
                picBox_hinhdt_CTDH.Image = Image.FromFile(linkanh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load ảnh thất bại, vui lòng kiểm tra lại đường dẫn tới ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // lấy số lượng điện thoại đã bán
            sldt_bancu_CTDH = Int32.Parse(txtSoLuongBan_CTHD.Text.Trim());

            // lấy số lượng hàng của điện thoại
            sql = "SELECT SOLUONG " +
                  "FROM DIENTHOAI " +
                  "WHERE MADT = '" + txtMaDienThoai_CTHD.Text.Trim() + "'";
            sldt_hang_CTDH = Int32.Parse(Class.Functions.GetFieldValues(sql));

            // Cập nhật trạng thái và xóa dữ liệu không cần thiết
            txtTenNhanVien_CTHD.Text = "";
            txtTenKhachHang_CTHD.Text = "";
            mtb_sdtkh_CTHD.Text = "";
            txtDiaChiKH_CTHD.Text = "";
            txtHangDienThoai_CTHD.Text = "";
            txtTenDienThoai_CTHD.Text = "";
            txtSoLuongHang_CTHD.Text = "";

            btnCapNhat_CTHD.Enabled = true;
            btnQuayLai_CTHD.Enabled = true;
            btnLuu_CTHD.Enabled = false;
            btnHuy_CTHD.Enabled = true;

            // Vô hiệu hóa các TextBox không cho phép chỉnh sửa
            txtMaDonHang_CTHD.Enabled = false;
            txtTenNhanVien_CTHD.Enabled = false;
            txtTenKhachHang_CTHD.Enabled = false;
            mtb_sdtkh_CTHD.Enabled = false;
            txtDiaChiKH_CTHD.Enabled = false;
            txtTenDienThoai_CTHD.Enabled = false;
            txtHangDienThoai_CTHD.Enabled = false;
            txtSoLuongHang_CTHD.Enabled = false;
            txtGiamGia_CTHD.Enabled = false;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            Resetvalues_CTDH();
            if (is_them_DH)
            {
                lb_them_CTDH.Text = "*Bạn đang ở chế độ thêm";
                txtMaDonHang_CTHD.Enabled = true;
                btnLuu_CTHD.Enabled = true;
                btnCapNhat_CTHD.Enabled = false;
            }
            else LoadData_CTDH();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sql;

            // TH nếu không có dữ liệu nhân viên
            if (noData_nv_CTDH)
            {
                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu không có dữ liệu khách hàng
            if (noData_kh_CTDH)
            {
                MessageBox.Show("Mã khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu không có dữ liệu điện thoại
            if (noData_dt_CTDH)
            {
                MessageBox.Show("Mã điện thoại không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu chưa nhập tổng tiền
            if (txtTongTien_CTHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // cập nhật lại số lượng bán, số lượng hàng nếu người dùng sửa
            sldt_ban_CTDH = sldt_banmoi_CTDH - sldt_bancu_CTDH;

            if (sldt_hang_CTDH < sldt_ban_CTDH)
            {
                MessageBox.Show("Không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (update_sldtmuamoi_CTDH)
            {
                // cập nhật lại sl điện thoại
                sql = "UPDATE DIENTHOAI " +
                    "SET SOLUONG = '" + (sldt_hang_CTDH - sldt_ban_CTDH).ToString() + "' " +
                    "WHERE MADT = '" + txtMaDienThoai_CTHD.Text.Trim().ToString() + "'";
                Class.Functions.RunSQL(sql);
            }

            // xử lí UPDATE
            sql = "UPDATE DONHANG " +
                "SET MANV = '" + txtMaNhanVien_CTHD.Text.Trim().ToString() + "', " +
                "MAKH = '" + txtMaKhachHang_CTHD.Text.Trim().ToString() + "', " +
                "MADT = '" + txtMaDienThoai_CTHD.Text.Trim().ToString() + "', " +
                "MAHANG = '" + mahang_CTDH + "', " +
                "GIAMGIA = '" + txtGiamGia_CTHD.Text.Trim().ToString() + "', " +
                "SOLUONG = '" + txtSoLuongBan_CTHD.Text.Trim().ToString() + "', " +
                "NGAYBAN = '" + Class.Functions.ConvertDateTime(dtpNgayBanCTDH.Text.Trim().ToString()) + "', " +
                "TONGTIEN = '" + txtTongTien_CTHD.Text.Trim().ToString() + "' " +
                "WHERE MADH = '" + txtMaDonHang_CTHD.Text.Trim().ToString() + "'";
            Class.Functions.RunSQL(sql);

            was_modify_CTDH = true;

            // thông báo cập nhật thành công
            MessageBox.Show("Cập Nhật Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // cập nhật lại số lượng hàng
            sql = "SELECT SOLUONG " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + txtMaDienThoai_CTHD.Text.Trim().ToString() + "'";
            txtSoLuongHang_CTHD.Text = Class.Functions.GetFieldValues(sql);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //TH nếu madh đã tồn tại
            string sql = "SELECT MADH " +
                "FROM " +
                "DONHANG " +
                "WHERE MADH = '" + txtMaDonHang_CTHD.Text.Trim().ToString() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã đơn hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDonHang_CTHD.Focus();
                return;
            }

            // TH nếu không có dữ liệu nhân viên
            if (noData_nv_CTDH)
            {
                MessageBox.Show("Mã nhân viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu không có dữ liệu khách hàng
            if (noData_kh_CTDH)
            {
                MessageBox.Show("Mã khách hàng không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu không có dữ liệu điện thoại
            if (noData_dt_CTDH)
            {
                MessageBox.Show("Mã điện thoại không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu chưa nhập số lương bán
            if (txtSoLuongBan_CTHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số lượng bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu chưa nhập giảm giá
            if (txtGiamGia_CTHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // TH nếu chưa nhập tổng tiền
            if (txtTongTien_CTHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // cập nhật lại số lượng bán, số lượng hàng nếu người dùng sửa
            sldt_ban_CTDH = sldt_banmoi_CTDH;

            if (sldt_hang_CTDH < sldt_ban_CTDH)
            {
                MessageBox.Show("Không đủ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (update_sldtmuamoi_CTDH)
            {
                // cập nhật lại sl điện thoại
                sql = "UPDATE DIENTHOAI " +
                    "SET SOLUONG = '" + (sldt_hang_CTDH - sldt_ban_CTDH).ToString() + "' " +
                    "WHERE MADT = '" + txtMaDienThoai_CTHD.Text.Trim().ToString() + "'";
                Class.Functions.RunSQL(sql);
            }

            // xử lí thêm
            sql = "INSERT INTO DONHANG " +
                "VALUES('" + txtMaDonHang_CTHD.Text.Trim().ToString() +
                "','" + txtMaKhachHang_CTHD.Text.Trim().ToString() +
                "','" + txtMaNhanVien_CTHD.Text.Trim().ToString() +
                "','" + txtMaDienThoai_CTHD.Text.Trim().ToString() +
                "','" + txtSoLuongBan_CTHD.Text.Trim() +
                "','" + txtGiamGia_CTHD.Text.Trim() +
                "','" + Class.Functions.ConvertDateTime(dtpNgayBanCTDH.Text.Trim().ToString()) +
                "','" + txtTongTien_CTHD.Text.Trim() +
                "','" + mahang_CTDH + "')";
            Class.Functions.RunSQL(sql);

            // thông báo thêm thành công
            MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            was_modify_CTDH = true;
            lb_them_CTDH.Text = "";
            btnCapNhat_CTHD.Enabled = true;
            btnLuu_CTHD.Enabled = false;

            // cập nhật lại số lượng hàng
            sql = "SELECT SOLUONG " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + txtMaDienThoai_CTHD.Text.Trim().ToString() + "'";
            txtSoLuongHang_CTHD.Text = Class.Functions.GetFieldValues(sql);

            madh_CTDH = txtMaDonHang_CTHD.Text.Trim().ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (is_them_DH && madh_CTDH.Length == 0)
            {
                Resetvalues_CTDH();
                txtMaDonHang_CTHD.Enabled = true;
                txtMaDonHang_CTHD.Focus();
                btnLuu_CTHD.Enabled = true;
                btnCapNhat_CTHD.Enabled = false;
            }
            else
                LoadData_CTDH();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT TENNV " +
                "FROM NHANVIEN " +
                "WHERE MANV = '" + txtMaNhanVien_CTHD.Text + "' ";
            string tennv = Class.Functions.GetFieldValues(sql);

            if (tennv.Length > 0)
            {
                noData_nv_CTDH = false;
                txtTenNhanVien_CTHD.Text = tennv;
            }
            else
            {
                txtTenNhanVien_CTHD.Text = "";
                noData_nv_CTDH = true;
            }
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT TENKH, SDT, DIACHI " +
                "FROM KHACHHANG " +
                "WHERE MAKH = '" + txtMaKhachHang_CTHD.Text + "' ";
            DataTable tblKH = Class.Functions.GetDataToTable(sql);

            if (tblKH.Rows.Count != 0)
            {
                noData_kh_CTDH = false;
                txtTenKhachHang_CTHD.Text = tblKH.Rows[0].Field<string>(0);
                mtb_sdtkh_CTHD.Text = tblKH.Rows[0].Field<string>(1);
                txtDiaChiKH_CTHD.Text = tblKH.Rows[0].Field<string>(2);
            }
            else
            {
                txtTenKhachHang_CTHD.Text = "";
                mtb_sdtkh_CTHD.Text = "";
                txtDiaChiKH_CTHD.Text = "";
                noData_kh_CTDH = true;
            }
        }

        private void txtMaDienThoai_TextChanged(object sender, EventArgs e)
        {
            // set tên dt, tên hãng, ảnh từ mã dt
            string sql = "SELECT DT.TENDT, HDT.TENHANG, DT.ANH, DT.MAHANG, DT.SOLUONG " +
                "FROM DIENTHOAI DT, HANGDIENTHOAI HDT " +
                "WHERE MADT = '" + txtMaDienThoai_CTHD.Text + "' " +
                "AND DT.MAHANG = HDT.MAHANG";
            DataTable tblDT = Class.Functions.GetDataToTable(sql);

            if (tblDT.Rows.Count != 0)
            {
                noData_dt_CTDH = false;
                txtTenDienThoai_CTHD.Text = tblDT.Rows[0].Field<string>(0);
                txtHangDienThoai_CTHD.Text = tblDT.Rows[0].Field<string>(1);
                mahang_CTDH = tblDT.Rows[0].Field<string>(3);
                txtSoLuongHang_CTHD.Text = tblDT.Rows[0].Field<Int32>(4).ToString();
                sldt_hang_CTDH = tblDT.Rows[0].Field<Int32>(4);
                try
                {
                    picBox_hinhdt_CTDH.Image = Image.FromFile(tblDT.Rows[0].Field<string>(2));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load ảnh thất bại, vui lòng kiểm tra lại đường dẫn tới ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                txtTenDienThoai_CTHD.Text = "";
                txtHangDienThoai_CTHD.Text = "";
                txtSoLuongHang_CTHD.Text = "";
                sldt_hang_CTDH = 0;
                picBox_hinhdt_CTDH.Image = null;
                noData_dt_CTDH = true;
            }

            //set giá bán điện thoại          
            sql = "SELECT GIABAN " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + txtMaDienThoai_CTHD.Text.Trim() + "'";
            txtGiaBan_CTHD.Text = Class.Functions.GetFieldValues(sql);

            // khi thay đổi madt thì số lượng bán, giảm giá, tổng tiền sẽ là 1 số mới
            txtGiamGia_CTHD.Text = "";
            txtSoLuongBan_CTHD.Text = "";
            txtTongTien_CTHD.Text = "";
            sldt_bancu_CTDH = 0;
        }

        private void btn_autotongtien_CTDH_Click(object sender, EventArgs e)
        {
            if (txtGiaBan_CTHD.Text.Trim().Length != 0 && txtSoLuongBan_CTHD.Text.Trim().Length != 0 &&
                txtGiamGia_CTHD.Text.Trim().Length != 0)
            {
                float giaban = float.Parse(txtGiaBan_CTHD.Text.Trim().ToString());
                int soluong = int.Parse(txtSoLuongBan_CTHD.Text.Trim().ToString());
                float giamgia = float.Parse(txtGiamGia_CTHD.Text.Trim().ToString());

                float tongtien = (giaban * soluong) - (giaban * (giamgia / 100));

                txtTongTien_CTHD.Text = ((int)tongtien).ToString();
            }
        }

        private void txtSoLuongBan_TextChanged(object sender, EventArgs e)
        {
            // kt nếu giá trị trong textBox là 1 số int
            if (!int.TryParse(txtSoLuongBan_CTHD.Text.Trim().ToString(), out sldt_banmoi_CTDH))
                return;

            // cập nhật số lượng mua mới        
            sldt_banmoi_CTDH = Int32.Parse(txtSoLuongBan_CTHD.Text.Trim().ToString());

            update_sldtmuamoi_CTDH = true;
        }
    }
}
