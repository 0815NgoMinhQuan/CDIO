namespace HeThongQuanLyBanHang.KhachHang
{
    partial class frmKhachHang
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbsdt_KH = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_KH = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHuy_KH = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu_KH = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat_KH = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa_KH = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem_KH = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage_khachhang = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbThem_KH = new System.Windows.Forms.Label();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.txtMaKhachHang_KH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKhachHang_KH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi_KH = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPage_khachhang.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(206, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 22);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tên Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(637, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 22);
            this.label14.TabIndex = 3;
            this.label14.Text = "Số Điện Thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(637, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Địa Chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(450, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(362, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // mtbsdt_KH
            // 
            this.mtbsdt_KH.Location = new System.Drawing.Point(768, 105);
            this.mtbsdt_KH.Mask = "999 000 0000";
            this.mtbsdt_KH.Name = "mtbsdt_KH";
            this.mtbsdt_KH.Size = new System.Drawing.Size(229, 39);
            this.mtbsdt_KH.TabIndex = 10;
            this.mtbsdt_KH.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(206, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã Khách Hàng";
            // 
            // dgv_KH
            // 
            this.dgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KH.Location = new System.Drawing.Point(3, 318);
            this.dgv_KH.Name = "dgv_KH";
            this.dgv_KH.RowHeadersWidth = 51;
            this.dgv_KH.RowTemplate.Height = 24;
            this.dgv_KH.Size = new System.Drawing.Size(1268, 398);
            this.dgv_KH.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnHuy_KH);
            this.panel6.Controls.Add(this.btnLuu_KH);
            this.panel6.Controls.Add(this.btnCapNhat_KH);
            this.panel6.Controls.Add(this.btnXoa_KH);
            this.panel6.Controls.Add(this.btnThem_KH);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 716);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1268, 95);
            this.panel6.TabIndex = 1;
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
            this.btnHuy_KH.Location = new System.Drawing.Point(1061, 22);
            this.btnHuy_KH.Name = "btnHuy_KH";
            this.btnHuy_KH.Size = new System.Drawing.Size(150, 50);
            this.btnHuy_KH.TabIndex = 22;
            this.btnHuy_KH.Text = "Hủy";
            // 
            // btnLuu_KH
            // 
            this.btnLuu_KH.BorderRadius = 20;
            this.btnLuu_KH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu_KH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_KH.ForeColor = System.Drawing.Color.White;
            this.btnLuu_KH.Location = new System.Drawing.Point(822, 22);
            this.btnLuu_KH.Name = "btnLuu_KH";
            this.btnLuu_KH.Size = new System.Drawing.Size(150, 50);
            this.btnLuu_KH.TabIndex = 21;
            this.btnLuu_KH.Text = "Lưu";
            // 
            // btnCapNhat_KH
            // 
            this.btnCapNhat_KH.BorderRadius = 20;
            this.btnCapNhat_KH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat_KH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat_KH.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat_KH.Location = new System.Drawing.Point(572, 22);
            this.btnCapNhat_KH.Name = "btnCapNhat_KH";
            this.btnCapNhat_KH.Size = new System.Drawing.Size(150, 50);
            this.btnCapNhat_KH.TabIndex = 20;
            this.btnCapNhat_KH.Text = "Cập Nhật";
            // 
            // btnXoa_KH
            // 
            this.btnXoa_KH.BorderRadius = 20;
            this.btnXoa_KH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_KH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_KH.ForeColor = System.Drawing.Color.White;
            this.btnXoa_KH.Location = new System.Drawing.Point(323, 22);
            this.btnXoa_KH.Name = "btnXoa_KH";
            this.btnXoa_KH.Size = new System.Drawing.Size(150, 50);
            this.btnXoa_KH.TabIndex = 19;
            this.btnXoa_KH.Text = "Xóa";
            // 
            // btnThem_KH
            // 
            this.btnThem_KH.BorderRadius = 20;
            this.btnThem_KH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem_KH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem_KH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_KH.ForeColor = System.Drawing.Color.White;
            this.btnThem_KH.Location = new System.Drawing.Point(57, 22);
            this.btnThem_KH.Name = "btnThem_KH";
            this.btnThem_KH.Size = new System.Drawing.Size(150, 50);
            this.btnThem_KH.TabIndex = 18;
            this.btnThem_KH.Text = "Thêm";
            // 
            // tabPage_khachhang
            // 
            this.tabPage_khachhang.Controls.Add(this.dgv_KH);
            this.tabPage_khachhang.Controls.Add(this.panel6);
            this.tabPage_khachhang.Controls.Add(this.panel5);
            this.tabPage_khachhang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_khachhang.Location = new System.Drawing.Point(4, 35);
            this.tabPage_khachhang.Name = "tabPage_khachhang";
            this.tabPage_khachhang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_khachhang.Size = new System.Drawing.Size(1274, 814);
            this.tabPage_khachhang.TabIndex = 2;
            this.tabPage_khachhang.Text = "   Khách Hàng   ";
            this.tabPage_khachhang.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtDiaChi_KH);
            this.panel5.Controls.Add(this.txtTenKhachHang_KH);
            this.panel5.Controls.Add(this.txtMaKhachHang_KH);
            this.panel5.Controls.Add(this.mtbsdt_KH);
            this.panel5.Controls.Add(this.lbThem_KH);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1268, 315);
            this.panel5.TabIndex = 0;
            // 
            // lbThem_KH
            // 
            this.lbThem_KH.AutoSize = true;
            this.lbThem_KH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbThem_KH.Location = new System.Drawing.Point(16, 281);
            this.lbThem_KH.Name = "lbThem_KH";
            this.lbThem_KH.Size = new System.Drawing.Size(0, 22);
            this.lbThem_KH.TabIndex = 9;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_khachhang);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1282, 853);
            this.tabControl_Main.TabIndex = 2;
            // 
            // txtMaKhachHang_KH
            // 
            this.txtMaKhachHang_KH.BorderRadius = 15;
            this.txtMaKhachHang_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKhachHang_KH.DefaultText = "";
            this.txtMaKhachHang_KH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKhachHang_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKhachHang_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKhachHang_KH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKhachHang_KH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKhachHang_KH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKhachHang_KH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKhachHang_KH.Location = new System.Drawing.Point(362, 105);
            this.txtMaKhachHang_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhachHang_KH.Name = "txtMaKhachHang_KH";
            this.txtMaKhachHang_KH.PlaceholderText = "";
            this.txtMaKhachHang_KH.SelectedText = "";
            this.txtMaKhachHang_KH.Size = new System.Drawing.Size(229, 39);
            this.txtMaKhachHang_KH.TabIndex = 11;
            // 
            // txtTenKhachHang_KH
            // 
            this.txtTenKhachHang_KH.BorderRadius = 15;
            this.txtTenKhachHang_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhachHang_KH.DefaultText = "";
            this.txtTenKhachHang_KH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhachHang_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhachHang_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang_KH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhachHang_KH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang_KH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKhachHang_KH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhachHang_KH.Location = new System.Drawing.Point(362, 182);
            this.txtTenKhachHang_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhachHang_KH.Name = "txtTenKhachHang_KH";
            this.txtTenKhachHang_KH.PlaceholderText = "";
            this.txtTenKhachHang_KH.SelectedText = "";
            this.txtTenKhachHang_KH.Size = new System.Drawing.Size(229, 39);
            this.txtTenKhachHang_KH.TabIndex = 12;
            // 
            // txtDiaChi_KH
            // 
            this.txtDiaChi_KH.BorderRadius = 15;
            this.txtDiaChi_KH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi_KH.DefaultText = "";
            this.txtDiaChi_KH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi_KH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi_KH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi_KH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi_KH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi_KH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi_KH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi_KH.Location = new System.Drawing.Point(768, 182);
            this.txtDiaChi_KH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi_KH.Name = "txtDiaChi_KH";
            this.txtDiaChi_KH.PlaceholderText = "";
            this.txtDiaChi_KH.SelectedText = "";
            this.txtDiaChi_KH.Size = new System.Drawing.Size(229, 104);
            this.txtDiaChi_KH.TabIndex = 13;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KH)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabPage_khachhang.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbsdt_KH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv_KH;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TabPage tabPage_khachhang;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbThem_KH;
        private System.Windows.Forms.TabControl tabControl_Main;
        private Guna.UI2.WinForms.Guna2Button btnHuy_KH;
        private Guna.UI2.WinForms.Guna2Button btnLuu_KH;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat_KH;
        private Guna.UI2.WinForms.Guna2Button btnXoa_KH;
        private Guna.UI2.WinForms.Guna2Button btnThem_KH;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi_KH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhachHang_KH;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKhachHang_KH;
    }
}