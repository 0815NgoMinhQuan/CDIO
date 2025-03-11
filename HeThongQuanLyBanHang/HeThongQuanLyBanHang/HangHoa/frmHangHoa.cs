using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyBanHang.HangHoa
{
    public partial class frmHangHoa: Form
    {
        DataTable tblHDT; // Chứa dữ liệu bảng HANGDIENTHOAI
        Class.hangdienthoai Obj_HDT = new Class.hangdienthoai();

        DataTable tblDT; // Chứa dữ liệu bảng DIENTHOAI

        bool mode_find_DT = false;
        Class.dienthoai Obj_DT = new Class.dienthoai();

        private void setFont_DT() // set Font cho các textBox 
        {
            txtMaDienThoai_DT.Font = new Font("Time New Roman", 12);
            txtTenDienThoai_DT.Font = new Font("Time New Roman", 12);
            txtSoLuong_DT.Font = new Font("Time New Roman", 12);
            txtGiaNhap_DT.Font = new Font("Time New Roman", 12);
            txtGiaBan_DT.Font = new Font("Time New Roman", 12);
            txtLinkAnh_DT.Font = new Font("Time New Roman", 12);
            cboHangDienThoai_DT.Font = new Font("Time New Roman", 12);
        }
        public frmHangHoa()
        {
            InitializeComponent();
            this.SuspendLayout();
            // 
            // HangHoa
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.ResumeLayout(false);
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadData_HDT();
        }   
        private void setFont_HDT() // set Font cho các textBox 
        {
            txtMaHang_HDT.Font = new Font("Time New Roman", 12);
            txtTenHang_HDT.Font = new Font("Time New Roman", 12);

        }
        private void ResetValues_HDT() // reset giá trị cho các mục 
        {
            txtMaHang_HDT.Text = "";
            txtTenHang_HDT.Text = "";

            btnCapNhat_HDT.Enabled = false;
            btnXoa_HDT.Enabled = false;
            btnLuu_HDT.Enabled = false;
            btnHuy_HDT.Enabled = false;
            txtMaHang_HDT.Enabled = false;
        }
        private void getData_fromTable_HDT() // lấy dữ liệu từ bảng
        {
            Obj_HDT.set_mahang(dgv_HDT.CurrentRow.Cells["MAHANG"].Value.ToString());
            Obj_HDT.set_tenhang(dgv_HDT.CurrentRow.Cells["TENHANG"].Value.ToString());
        }
        private void getData_fromTxtBox_HDT() // lấy dữ liệu từ các TextBox
        {
            Obj_HDT.Reset();

            Obj_HDT.set_mahang(txtMaHang_HDT.Text.Trim().ToString());
            Obj_HDT.set_tenhang(txtTenHang_HDT.Text.Trim().ToString());
        }
        private void LoadData_HDT() // tải dữ liệu vào DataGridView
        {
            ResetValues_HDT();
            setFont_HDT();

            string sql = "SELECT MAHANG, TENHANG " +
                  "FROM HANGDIENTHOAI";
            tblHDT = Class.Functions.GetDataToTable(sql);
            dgv_HDT.DataSource = tblHDT;

            // set Font cho tên cột
            dgv_HDT.Font = new Font("Time New Roman", 13);
            dgv_HDT.Columns[0].HeaderText = "Mã Hãng";
            dgv_HDT.Columns[1].HeaderText = "Tên Hãng";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_HDT.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_HDT.Columns[0].Width = 430;
            dgv_HDT.Columns[1].Width = 430;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_HDT.AllowUserToAddRows = false;
            dgv_HDT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThemHDT_Click(object sender, EventArgs e)
        {
            ResetValues_HDT();
            // set label thông báo cho người dùng biết là đang ở chế độ thêm
            lbThem_HDT.Text = "*Bạn đang ở chế độ thêm";
            // xử lí enable các nút
            txtMaHang_HDT.Enabled = true;
            txtMaHang_HDT.Focus();
            btnHuy_HDT.Enabled = true;
            btnLuu_HDT.Enabled = true;
            btnThem_HDT.Enabled = false;
        }

        private void dgv_HDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu không có dữ liệu
            if (tblHDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // nếu đang ở chế độ thêm mà user click vào DataGridView
            if (btnThem_HDT.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang_HDT.Focus();
                return;
            }

            // set dữ liệu cho textBox
            getData_fromTable_HDT();
            txtMaHang_HDT.Text = Obj_HDT.get_mahang();
            txtTenHang_HDT.Text = Obj_HDT.get_tenhang();

            // xử lí Enable các nút
            btnCapNhat_HDT.Enabled = true;
            btnXoa_HDT.Enabled = true;
            btnHuy_HDT.Enabled = true;
        }
        private void btnXoa_HDT_Click(object sender, EventArgs e)
        {
            // hỏi người dùng có chắc chắn xóa không
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE HANGDIENTHOAI" +
                    " WHERE MAHANG = N'" + txtMaHang_HDT.Text + "'";
                Class.Functions.RunSQL(sql);

                // tải dữ liệu vào dataGridView
                LoadData_HDT();
                ResetValues_HDT();
            }
        }

        private void btnCapNhat_HDT_Click(object sender, EventArgs e)
        {
            getData_fromTxtBox_HDT();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_HDT.Check_Data())
            {
                MessageBox.Show("Vui lòng đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang_HDT.Focus();
                return;
            }

            // thực hiện câu lệnh sql cập nhật dữ liệu
            string sql = "UPDATE HANGDIENTHOAI" +
                " SET TENHANG = N'" + Obj_HDT.get_tenhang() +
                "' WHERE MAHANG = '" + Obj_HDT.get_mahang() + "'";
            Class.Functions.RunSQL(sql);

            // tải dữ liệu vào dataGridView
            LoadData_HDT();
            ResetValues_HDT();

            // xử lí enable các nút
            btnHuy_HDT.Enabled = false;
        }

        private void btnLuu_HDT_Click(object sender, EventArgs e)
        {
            getData_fromTxtBox_HDT();

            // nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_HDT.Check_Data())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang_HDT.Focus();
                return;
            }

            // kiểm tra có trùng mã hãng hay không
            string sql = "Select MAHANG " +
                "From HANGDIENTHOAI " +
                "where MAHANG = N'" + Obj_HDT.get_mahang() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hãng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang_HDT.Focus();
                return;
            }

            // thực hiện câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO HANGDIENTHOAI " +
                "VALUES('" + Obj_HDT.get_mahang() + "',N'" + Obj_HDT.get_tenhang() + "')";
            Class.Functions.RunSQL(sql);

            // tải dữ liệu vào dataGridView
            LoadData_HDT();
            ResetValues_HDT();

            // xử lí enable các nút
            btnThem_HDT.Enabled = true;
            lbThem_HDT.Text = "";
        }

        private void btnHuy_HDT_Click(object sender, EventArgs e)
        {
            // nếu đang ở chế độ thêm
            if (btnThem_HDT.Enabled == false)
                lbThem_HDT.Text = "";

            ResetValues_HDT();
            btnThem_HDT.Enabled = true;
        }
        private void tabPage_hangdienthoai_Leave(object sender, EventArgs e) // xử lí khi rời tab 
        {
            ResetValues_HDT();
            if (btnThem_HDT.Enabled == false)
                lbThem_HDT.Text = "";
            btnThem_HDT.Enabled = true;
        }

        private void ResetValues_DT() // reset giá trị cho các mục 
        {
            if (!mode_find_DT)
                cboHangDienThoai_DT.Text = "";

            txtMaDienThoai_DT.Text = "";
            txtTenDienThoai_DT.Text = "";
            txtSoLuong_DT.Text = "";
            txtGiaNhap_DT.Text = "";
            txtGiaBan_DT.Text = "";
            txtLinkAnh_DT.Text = "";
            picAnh_DT.Image = null;

            btnCapNhat_DT.Enabled = false;
            btnXoa_DT.Enabled = false;
            btnLuu_DT.Enabled = false;
            btnHuy_DT.Enabled = false;
            txtMaDienThoai_DT.Enabled = false;
        }
        private void getData_fromTable_DT() // lấy dữ liệu từ bảng
        {
            Obj_DT.set_mahang(dgv_DT.CurrentRow.Cells["MAHANG"].Value.ToString());
            Obj_DT.set_madt(dgv_DT.CurrentRow.Cells["MADT"].Value.ToString());
            Obj_DT.set_tendt(dgv_DT.CurrentRow.Cells["TENDT"].Value.ToString());
            Obj_DT.set_soluong(dgv_DT.CurrentRow.Cells["SOLUONG"].Value.ToString());
            Obj_DT.set_gianhap(dgv_DT.CurrentRow.Cells["GIANHAP"].Value.ToString());
            Obj_DT.set_giaban(dgv_DT.CurrentRow.Cells["GIABAN"].Value.ToString());
            Obj_DT.set_linkanh(dgv_DT.CurrentRow.Cells["ANH"].Value.ToString());
        }
        private void getData_fromTxtBox_DT() // lấy dữ liệu từ các TextBox
        {
            Obj_DT.Reset();

            Obj_DT.set_mahang(cboHangDienThoai_DT.SelectedValue.ToString());
            Obj_DT.set_madt(txtMaDienThoai_DT.Text.Trim().ToString());
            Obj_DT.set_tendt(txtTenDienThoai_DT.Text.Trim().ToString());
            Obj_DT.set_soluong(txtSoLuong_DT.Text.Trim().ToString());
            Obj_DT.set_gianhap(txtGiaNhap_DT.Text.Trim().ToString());
            Obj_DT.set_giaban(txtGiaBan_DT.Text.Trim().ToString());
            Obj_DT.set_linkanh(txtLinkAnh_DT.Text.Trim().ToString());
        }
        private void tabPage_dienthoai_Enter(object sender, EventArgs e) //tải dữ liệu khi vào tab 
        {
            // load dữ liệu cho comboBox tên hãng điện thoại
            string sql = "SELECT * " +
                  "FROM HANGDIENTHOAI";
            Class.Functions.FillCombo(sql, cboHangDienThoai_DT, "MAHANG", "TENHANG");
            cboHangDienThoai_DT.SelectedIndex = -1;

            ResetValues_DT();
            setFont_DT();
            LoadData_DienThoai();
        }
        private void tabPage_dienthoai_Leave(object sender, EventArgs e) // xử lí khi rời tab
        {
            ResetValues_DT();

            if (btnThem_DT.Enabled == false)
                lb_them_DT.Text = "";
            btnThem_DT.Enabled = true;
        }
        private void LoadData_DienThoai() // tải dữ liệu vào DataGridView
        {
            string sql = "SELECT * FROM DIENTHOAI";
            tblDT = Class.Functions.GetDataToTable(sql);
            dgv_DT.DataSource = tblDT;

            // set Font cho tên cột
            dgv_DT.Font = new Font("Time New Roman", 13);
            dgv_DT.Columns[0].HeaderText = "Mã Điện Thoại";
            dgv_DT.Columns[1].HeaderText = "Tên Điện Thoại";
            dgv_DT.Columns[2].HeaderText = "Mã Hãng";
            dgv_DT.Columns[3].HeaderText = "Số Lượng";
            dgv_DT.Columns[4].HeaderText = "Giá Nhập";
            dgv_DT.Columns[5].HeaderText = "Giá Bán";
            dgv_DT.Columns[6].HeaderText = "Ảnh";

            // set Font cho dữ liệu hiển thị trong cột
            dgv_DT.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dgv_DT.Columns[0].Width = 155;
            dgv_DT.Columns[1].Width = 160;
            dgv_DT.Columns[2].Width = 115;
            dgv_DT.Columns[3].Width = 115;
            dgv_DT.Columns[4].Width = 110;
            dgv_DT.Columns[5].Width = 100;
            dgv_DT.Columns[6].Width = 200;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dgv_DT.AllowUserToAddRows = false;
            dgv_DT.EditMode = DataGridViewEditMode.EditProgrammatically;

            if (mode_find_DT)
                cboHangDienThoai_DT.Text = "";
        }

        private void dgv_DT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu không có dữ liệu
            if (tblDT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // nếu đang ở chế độ thêm mà user click vào DataGridView
            if (btnThem_DT.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDienThoai_DT.Focus();
                return;
            }

            // set giá trị cho các TextBox, set ảnh
            getData_fromTable_DT();
            txtMaDienThoai_DT.Text = Obj_DT.get_madt();
            txtTenDienThoai_DT.Text = Obj_DT.get_tendt();
            txtSoLuong_DT.Text = Obj_DT.get_soluong();
            txtGiaNhap_DT.Text = Obj_DT.get_gianhap();
            txtGiaBan_DT.Text = Obj_DT.get_giaban();
            txtLinkAnh_DT.Text = Obj_DT.get_linkanh();

            try
            {
                picAnh_DT.Image = Image.FromFile(Obj_DT.get_linkanh());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load ảnh thất bại, vui lòng kiểm tra lại đường dẫn tới ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // lấy Tên Hãng thông qua Mã Hãng và set giá trị cho comboBox        
            string sql = "SELECT TENHANG " +
                "FROM HANGDIENTHOAI " +
                "WHERE MAHANG = '" + Obj_DT.get_mahang() + "'";
            cboHangDienThoai_DT.Text = Class.Functions.GetFieldValues(sql);

            // xử lí enable các nút
            btnCapNhat_DT.Enabled = true;
            btnXoa_DT.Enabled = true;
            btnHuy_DT.Enabled = true;
        }

        private void btnThem_DT_Click(object sender, EventArgs e)
        {
            ResetValues_DT();

            // set label thông báo cho người dùng biết là đang ở chế độ thêm
            lb_them_DT.ForeColor = System.Drawing.Color.Red;
            lb_them_DT.Text = "*Bạn đang ở chế độ thêm";

            // xử lí enable các nút
            txtMaDienThoai_DT.Enabled = true;
            txtMaDienThoai_DT.Focus();
            btnHuy_DT.Enabled = true;
            btnLuu_DT.Enabled = true;
            btnThem_DT.Enabled = false;
        }

        private void btnXoa_DT_Click(object sender, EventArgs e)
        {
            // hỏi người dùng có chắc chắn xóa không ?
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // thực hiện câu lệnh sql xóa
                string sql = "DELETE " +
                    "DIENTHOAI " +
                    "WHERE MADT = N'" + txtMaDienThoai_DT.Text + "'";
                Class.Functions.RunSQL(sql);

                // tải dữ liệu lên dataGridView
                if (mode_find_DT)
                    setDaTa_FindMode_DT();
                else
                {
                    LoadData_DienThoai();
                    ResetValues_DT();
                }
            }
        }

        private void btnCapNhat_DT_Click(object sender, EventArgs e)
        {
            getData_fromTxtBox_DT();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_DT.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí câu lệnh sql cập nhật dữ liệu
            string sql = "UPDATE DIENTHOAI " +
                "SET TENDT = N'" + Obj_DT.get_tendt() + "'," +
                "MAHANG = '" + Obj_DT.get_mahang() + "'," +
                "SOLUONG = '" + Obj_DT.get_soluong() + "'," +
                "GIANHAP = '" + Obj_DT.get_gianhap() + "'," +
                "GIABAN = '" + Obj_DT.get_giaban() + "'," +
                "ANH = N'" + Obj_DT.get_linkanh() + "'" +
                "WHERE MADT = '" + Obj_DT.get_madt() + "'";
            Class.Functions.RunSQL(sql);

            if (mode_find_DT)
                setDaTa_FindMode_DT();
            else
            {
                LoadData_DienThoai();
                ResetValues_DT();
            }
        }

        private void btnLuu_DT_Click(object sender, EventArgs e)
        {
            getData_fromTxtBox_DT();

            // TH nếu chưa nhập đầy đủ dữ liệu
            if (!Obj_DT.Check_Data())
            {
                MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // xử lí khi trùng mã điện thoại
            string sql = "SELECT " +
                "MADT " +
                "FROM DIENTHOAI " +
                "WHERE MADT = '" + Obj_DT.get_madt() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDienThoai_DT.Focus();
                return;
            }

            // xử lí câu lệnh sql thêm dữ liệu
            sql = "INSERT INTO DIENTHOAI " +
                "VALUES('" + Obj_DT.get_madt() +
                "',N'" + Obj_DT.get_tendt() +
                "','" + Obj_DT.get_mahang() +
                "','" + Obj_DT.get_soluong() +
                "','" + Obj_DT.get_gianhap() +
                "','" + Obj_DT.get_giaban() +
                "',N'" + Obj_DT.get_linkanh() + "')";
            Class.Functions.RunSQL(sql);

            // tải dữ liệu lên dataGridView
            if (mode_find_DT)
                setDaTa_FindMode_DT();
            else
            {
                LoadData_DienThoai();
                ResetValues_DT();
            }

            btnThem_DT.Enabled = true;
            lb_them_DT.Text = "";
        }

        private void btnHuy_DT_Click(object sender, EventArgs e)
        {
            // nếu đang ở chế độ thêm
            if (btnThem_DT.Enabled == false)
                lb_them_DT.Text = "";

            // nếu đang ở chế độ tìm kiếm
            if (mode_find_DT)
            {
                LoadData_DienThoai();
                mode_find_DT = false;
            }

            ResetValues_DT();
            btnThem_DT.Enabled = true;
        }

        private void btnChonhinh_DT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình minh họa";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh_DT.Image = Image.FromFile(dlgOpen.FileName);
                txtLinkAnh_DT.Text = dlgOpen.FileName;
            }
        }
        private void btnTimKiemDT_Click(object sender, EventArgs e)
        {
            mode_find_DT = true;

            // nếu đang ở chế độ thêm mà user click vào nút tìm kiếm
            if (btnThem_DT.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDienThoai_DT.Focus();
                return;
            }

            // TH nếu chưa chọn tên hãng 
            if (cboHangDienThoai_DT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn tên hãng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            setDaTa_FindMode_DT();

            // nếu tìm ko ra dữ liệu 
            if (tblDT.Rows.Count == 0)
                MessageBox.Show("Không có hàng của hãng " + cboHangDienThoai_DT.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void setDaTa_FindMode_DT() // tải dữ liệu đã tìm kiếm dc vào DataGridView
        {
            // thực hiện câu lệnh SQL
            string sql = "SELECT * " +
                "FROM DIENTHOAI " +
                "WHERE MAHANG = '" + cboHangDienThoai_DT.SelectedValue + "'";
            tblDT = Class.Functions.GetDataToTable(sql);

            // tải dữ liệu lên dataGridView
            dgv_DT.DataSource = tblDT;

            // reset giá trị cho các mục trừ mục tên hãng điện thoại,xử lí enable các nút       
            ResetValues_DT();
            btnHuy_DT.Enabled = true;
        }
    }
}
