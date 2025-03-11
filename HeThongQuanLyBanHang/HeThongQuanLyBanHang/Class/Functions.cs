using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyBanHang.Class
{
    class Functions
    {
        //Khai báo đối tượng kết nối  
        public static SqlConnection Con;

        public static void Connect()
        {
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\ql_bandienthoai.mdf
            ;Integrated Security=True;Connect Timeout=30";
            //Mở kết nối
            Con.Open();

            ////Kiểm tra kết nối
            //if (Con.State == ConnectionState.Open)
            //    MessageBox.Show("Kết nối DB thành công");
            //else MessageBox.Show("Không thể kết nối với DB");
        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                //Đóng kết nối
                Con.Close();

                //Giải phóng tài nguyên
                Con.Dispose();
                Con = null;

                //Kiểm tra kết nối
                //MessageBox.Show("Đóng Kết nối DB thành công");
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            if (Con == null)
            {
                MessageBox.Show("Chưa kết nối đến CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            DataTable table = new DataTable();
            try
            {
                using (SqlDataAdapter dap = new SqlDataAdapter(sql, Con))
                {
                    dap.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        public static bool CheckKey(string sql) // kiểm tra xem có trùng khóa hay không
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSQL(string sql)
        {
            if (Con == null || Con.State == ConnectionState.Closed)
            {
                MessageBox.Show("Chưa kết nối đến CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlCommand cmd = new SqlCommand(sql, Con))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten) // đổ dữ liệu vào comboBox
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static string GetFieldValues(string sql)
        {
            string result = "";
            if (Con == null || Con.State == ConnectionState.Closed)
            {
                MessageBox.Show("Chưa kết nối đến CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

            using (SqlCommand cmd = new SqlCommand(sql, Con))
            {
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader.GetValue(0).ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return result;
        }
        // chuyển dd/mm/yy -> mm/dd/yy. Vì mm/dd/yy khi lưu vào csdl sẽ tự chuyển thành 
        // dd/mm/yy , khi ta lấy ra nó sẽ có dạng dd/mm/yy 
        // tiện cho việc lấy dữ liệu ra và gán vào textBox luôn
        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('-');
            string dt = string.Format("{0}/{1}/{2}", elements[1], elements[0], elements[2]);
            return dt;
        }

        private static string get_imageName(string linkanh) // lấy tên ảnh
        {
            string tenanh = "";
            char ktdung = '\\';
            int d = 0;

            // lấy vị trí bắt đầu của tên ảnh
            for (int i = linkanh.Length - 1; i >= 0; i--)
            {
                if (linkanh[i] == ktdung) break;
                d++;
            }

            for (int i = linkanh.Length - d; i < linkanh.Length; i++)
                tenanh += linkanh[i];
            return tenanh;
        }

        public static void update_imageLink()
        {
            DataTable tbl = GetDataToTable("SELECT * FROM DIENTHOAI");
            string linkanh;
            string madt;
            string path = System.IO.Directory.GetCurrentDirectory();

            foreach (DataRow row in tbl.Rows)
            {
                linkanh = row["ANH"].ToString();
                madt = row["MADT"].ToString();

                string linkanhmoi = path + "\\HinhDienThoai\\" + get_imageName(linkanh);
                string sql = "UPDATE DIENTHOAI SET ANH = N'" + linkanhmoi + "' WHERE MADT = '" + madt + "'";
                Class.Functions.RunSQL(sql);
            }

        }
    }
}
