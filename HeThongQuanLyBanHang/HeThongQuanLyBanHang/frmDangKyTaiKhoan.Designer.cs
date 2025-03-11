namespace HeThongQuanLyBanHang
{
    partial class frmDangKyTaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chkshowpass = new System.Windows.Forms.CheckBox();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhapLaiPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuyDangKy = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyDangKy);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Controls.Add(this.txtNhapLaiPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkshowpass);
            this.panel1.Controls.Add(this.lblconfirmpassword);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 448);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 48);
            this.label4.TabIndex = 19;
            this.label4.Text = "Đăng ký tài khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkshowpass
            // 
            this.chkshowpass.AutoSize = true;
            this.chkshowpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowpass.Location = new System.Drawing.Point(255, 282);
            this.chkshowpass.Name = "chkshowpass";
            this.chkshowpass.Size = new System.Drawing.Size(233, 33);
            this.chkshowpass.TabIndex = 18;
            this.chkshowpass.Text = "Hiện thị mật khẩu";
            this.chkshowpass.UseVisualStyleBackColor = true;
            this.chkshowpass.CheckedChanged += new System.EventHandler(this.chkshowpass_CheckedChanged);
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.Location = new System.Drawing.Point(27, 246);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(218, 29);
            this.lblconfirmpassword.TabIndex = 17;
            this.lblconfirmpassword.Text = "Nhập lại mật khẩu";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(27, 174);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(185, 29);
            this.lblpassword.TabIndex = 13;
            this.lblpassword.Text = "Nhập mật khẩu";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(27, 100);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(166, 29);
            this.lblusername.TabIndex = 12;
            this.lblusername.Text = "Tên tài khoản";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(255, 81);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(295, 48);
            this.txtUsername.TabIndex = 20;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(255, 155);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(295, 48);
            this.txtPassword.TabIndex = 21;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtNhapLaiPassword
            // 
            this.txtNhapLaiPassword.BorderRadius = 20;
            this.txtNhapLaiPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapLaiPassword.DefaultText = "";
            this.txtNhapLaiPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapLaiPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapLaiPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapLaiPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhapLaiPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapLaiPassword.Location = new System.Drawing.Point(255, 227);
            this.txtNhapLaiPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhapLaiPassword.Name = "txtNhapLaiPassword";
            this.txtNhapLaiPassword.PlaceholderText = "";
            this.txtNhapLaiPassword.SelectedText = "";
            this.txtNhapLaiPassword.Size = new System.Drawing.Size(295, 48);
            this.txtNhapLaiPassword.TabIndex = 22;
            this.txtNhapLaiPassword.TextChanged += new System.EventHandler(this.txtNhapLaiPassword_TextChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BorderRadius = 20;
            this.btnDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(255, 321);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(295, 45);
            this.btnDangKy.TabIndex = 23;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.BorderRadius = 20;
            this.btnHuyDangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyDangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyDangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyDangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuyDangKy.ForeColor = System.Drawing.Color.White;
            this.btnHuyDangKy.Location = new System.Drawing.Point(255, 379);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(295, 45);
            this.btnHuyDangKy.TabIndex = 24;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // frmDangKyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmDangKyTaiKhoan";
            this.Text = "Đăng Ký Tài Khoản";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkshowpass;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private Guna.UI2.WinForms.Guna2Button btnHuyDangKy;
        private Guna.UI2.WinForms.Guna2Button btnDangKy;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapLaiPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
    }
}

