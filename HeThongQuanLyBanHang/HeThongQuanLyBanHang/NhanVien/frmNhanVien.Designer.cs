namespace HeThongQuanLyBanHang.NhanVien
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.mtbsdt_NV = new System.Windows.Forms.MaskedTextBox();
            this.dtpngaysinh_NV = new System.Windows.Forms.DateTimePicker();
            this.lb_them_NV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_nhanvien = new System.Windows.Forms.TabPage();
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.btnHuy_KH = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu_NV = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat_NV = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa_NV = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem_NV = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiaChi_NV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNhanVien_NV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNhanVien_NV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGioiTinh_NV = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            this.tabPage_nhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 1;
            // 
            // mtbsdt_NV
            // 
            this.mtbsdt_NV.Location = new System.Drawing.Point(771, 146);
            this.mtbsdt_NV.Mask = "999 000 0000";
            this.mtbsdt_NV.Name = "mtbsdt_NV";
            this.mtbsdt_NV.Size = new System.Drawing.Size(185, 39);
            this.mtbsdt_NV.TabIndex = 16;
            this.mtbsdt_NV.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtpngaysinh_NV
            // 
            this.dtpngaysinh_NV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaysinh_NV.Location = new System.Drawing.Point(771, 82);
            this.dtpngaysinh_NV.Name = "dtpngaysinh_NV";
            this.dtpngaysinh_NV.Size = new System.Drawing.Size(185, 39);
            this.dtpngaysinh_NV.TabIndex = 15;
            // 
            // lb_them_NV
            // 
            this.lb_them_NV.AutoSize = true;
            this.lb_them_NV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_them_NV.ForeColor = System.Drawing.Color.Red;
            this.lb_them_NV.Location = new System.Drawing.Point(17, 294);
            this.lb_them_NV.Name = "lb_them_NV";
            this.lb_them_NV.Size = new System.Drawing.Size(0, 22);
            this.lb_them_NV.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtGioiTinh_NV);
            this.panel2.Controls.Add(this.txtDiaChi_NV);
            this.panel2.Controls.Add(this.txtTenNhanVien_NV);
            this.panel2.Controls.Add(this.txtMaNhanVien_NV);
            this.panel2.Controls.Add(this.mtbsdt_NV);
            this.panel2.Controls.Add(this.dtpngaysinh_NV);
            this.panel2.Controls.Add(this.lb_them_NV);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1268, 335);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(625, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Số Điện Thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(659, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ngày Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(678, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(253, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(214, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(214, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(463, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // tabPage_nhanvien
            // 
            this.tabPage_nhanvien.Controls.Add(this.dgv_NV);
            this.tabPage_nhanvien.Controls.Add(this.panel3);
            this.tabPage_nhanvien.Controls.Add(this.panel2);
            this.tabPage_nhanvien.Controls.Add(this.label3);
            this.tabPage_nhanvien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_nhanvien.Location = new System.Drawing.Point(4, 35);
            this.tabPage_nhanvien.Name = "tabPage_nhanvien";
            this.tabPage_nhanvien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_nhanvien.Size = new System.Drawing.Size(1274, 814);
            this.tabPage_nhanvien.TabIndex = 1;
            this.tabPage_nhanvien.Text = "   Nhân Viên   ";
            this.tabPage_nhanvien.UseVisualStyleBackColor = true;
            // 
            // dgv_NV
            // 
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NV.Location = new System.Drawing.Point(3, 338);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.RowHeadersWidth = 51;
            this.dgv_NV.RowTemplate.Height = 24;
            this.dgv_NV.Size = new System.Drawing.Size(1268, 377);
            this.dgv_NV.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHuy_KH);
            this.panel3.Controls.Add(this.btnLuu_NV);
            this.panel3.Controls.Add(this.btnCapNhat_NV);
            this.panel3.Controls.Add(this.btnXoa_NV);
            this.panel3.Controls.Add(this.btnThem_NV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 715);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1268, 96);
            this.panel3.TabIndex = 3;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_nhanvien);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1282, 853);
            this.tabControl_Main.TabIndex = 2;
            // 
            // btnHuy_KH
            // 
            this.btnHuy_KH.BorderRadius = 20;
            this.btnHuy_KH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy_KH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy_KH.ForeColor = System.Drawing.Color.White;
            this.btnHuy_KH.Location = new System.Drawing.Point(1061, 23);
            this.btnHuy_KH.Name = "btnHuy_KH";
            this.btnHuy_KH.Size = new System.Drawing.Size(150, 50);
            this.btnHuy_KH.TabIndex = 27;
            this.btnHuy_KH.Text = "Hủy";
            // 
            // btnLuu_NV
            // 
            this.btnLuu_NV.BorderRadius = 20;
            this.btnLuu_NV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu_NV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu_NV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_NV.ForeColor = System.Drawing.Color.White;
            this.btnLuu_NV.Location = new System.Drawing.Point(822, 23);
            this.btnLuu_NV.Name = "btnLuu_NV";
            this.btnLuu_NV.Size = new System.Drawing.Size(150, 50);
            this.btnLuu_NV.TabIndex = 26;
            this.btnLuu_NV.Text = "Lưu";
            // 
            // btnCapNhat_NV
            // 
            this.btnCapNhat_NV.BorderRadius = 20;
            this.btnCapNhat_NV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat_NV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat_NV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat_NV.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat_NV.Location = new System.Drawing.Point(572, 23);
            this.btnCapNhat_NV.Name = "btnCapNhat_NV";
            this.btnCapNhat_NV.Size = new System.Drawing.Size(150, 50);
            this.btnCapNhat_NV.TabIndex = 25;
            this.btnCapNhat_NV.Text = "Cập Nhật";
            // 
            // btnXoa_NV
            // 
            this.btnXoa_NV.BorderRadius = 20;
            this.btnXoa_NV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_NV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa_NV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_NV.ForeColor = System.Drawing.Color.White;
            this.btnXoa_NV.Location = new System.Drawing.Point(323, 23);
            this.btnXoa_NV.Name = "btnXoa_NV";
            this.btnXoa_NV.Size = new System.Drawing.Size(150, 50);
            this.btnXoa_NV.TabIndex = 24;
            this.btnXoa_NV.Text = "Xóa";
            // 
            // btnThem_NV
            // 
            this.btnThem_NV.BorderRadius = 20;
            this.btnThem_NV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem_NV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem_NV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_NV.ForeColor = System.Drawing.Color.White;
            this.btnThem_NV.Location = new System.Drawing.Point(57, 23);
            this.btnThem_NV.Name = "btnThem_NV";
            this.btnThem_NV.Size = new System.Drawing.Size(150, 50);
            this.btnThem_NV.TabIndex = 23;
            this.btnThem_NV.Text = "Thêm";
            // 
            // txtDiaChi_NV
            // 
            this.txtDiaChi_NV.BorderRadius = 15;
            this.txtDiaChi_NV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi_NV.DefaultText = "";
            this.txtDiaChi_NV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi_NV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi_NV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi_NV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi_NV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi_NV.Location = new System.Drawing.Point(771, 212);
            this.txtDiaChi_NV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi_NV.Name = "txtDiaChi_NV";
            this.txtDiaChi_NV.PlaceholderText = "";
            this.txtDiaChi_NV.SelectedText = "";
            this.txtDiaChi_NV.Size = new System.Drawing.Size(229, 104);
            this.txtDiaChi_NV.TabIndex = 19;
            // 
            // txtTenNhanVien_NV
            // 
            this.txtTenNhanVien_NV.BorderRadius = 15;
            this.txtTenNhanVien_NV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanVien_NV.DefaultText = "";
            this.txtTenNhanVien_NV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhanVien_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhanVien_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien_NV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien_NV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien_NV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNhanVien_NV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNhanVien_NV.Location = new System.Drawing.Point(362, 146);
            this.txtTenNhanVien_NV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNhanVien_NV.Name = "txtTenNhanVien_NV";
            this.txtTenNhanVien_NV.PlaceholderText = "";
            this.txtTenNhanVien_NV.SelectedText = "";
            this.txtTenNhanVien_NV.Size = new System.Drawing.Size(229, 39);
            this.txtTenNhanVien_NV.TabIndex = 18;
            // 
            // txtMaNhanVien_NV
            // 
            this.txtMaNhanVien_NV.BorderRadius = 15;
            this.txtMaNhanVien_NV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien_NV.DefaultText = "";
            this.txtMaNhanVien_NV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhanVien_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhanVien_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien_NV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien_NV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien_NV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNhanVien_NV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien_NV.Location = new System.Drawing.Point(362, 82);
            this.txtMaNhanVien_NV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien_NV.Name = "txtMaNhanVien_NV";
            this.txtMaNhanVien_NV.PlaceholderText = "";
            this.txtMaNhanVien_NV.SelectedText = "";
            this.txtMaNhanVien_NV.Size = new System.Drawing.Size(229, 39);
            this.txtMaNhanVien_NV.TabIndex = 17;
            // 
            // txtGioiTinh_NV
            // 
            this.txtGioiTinh_NV.BorderRadius = 15;
            this.txtGioiTinh_NV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioiTinh_NV.DefaultText = "";
            this.txtGioiTinh_NV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGioiTinh_NV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGioiTinh_NV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioiTinh_NV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioiTinh_NV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioiTinh_NV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGioiTinh_NV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioiTinh_NV.Location = new System.Drawing.Point(362, 212);
            this.txtGioiTinh_NV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioiTinh_NV.Name = "txtGioiTinh_NV";
            this.txtGioiTinh_NV.PlaceholderText = "";
            this.txtGioiTinh_NV.SelectedText = "";
            this.txtGioiTinh_NV.Size = new System.Drawing.Size(229, 39);
            this.txtGioiTinh_NV.TabIndex = 20;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage_nhanvien.ResumeLayout(false);
            this.tabPage_nhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbsdt_NV;
        private System.Windows.Forms.DateTimePicker dtpngaysinh_NV;
        private System.Windows.Forms.Label lb_them_NV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_nhanvien;
        private System.Windows.Forms.DataGridView dgv_NV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl_Main;
        private Guna.UI2.WinForms.Guna2Button btnHuy_KH;
        private Guna.UI2.WinForms.Guna2Button btnLuu_NV;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat_NV;
        private Guna.UI2.WinForms.Guna2Button btnXoa_NV;
        private Guna.UI2.WinForms.Guna2Button btnThem_NV;
        private Guna.UI2.WinForms.Guna2TextBox txtGioiTinh_NV;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi_NV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien_NV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien_NV;
    }
}