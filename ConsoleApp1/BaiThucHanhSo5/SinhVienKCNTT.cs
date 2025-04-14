using System;
using System.Globalization;

namespace BaiThucHanhSo5
{
    class SinhVienDienTu
    {
        private string mssv;
        private string hoten;
        private string diachi;
        private DateTime ngaysinh;
        private double diemEE200;
        private double diemEE201;
        private double diemEE205;

        public string MSSV { get => mssv; set => mssv = value; }
        public string HoTen { get => hoten; set => hoten = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public DateTime NgaySinh { get => ngaysinh; set => ngaysinh = value; }
        public double DiemEE200 { get => diemEE200; set => diemEE200 = value; }
        public double DiemEE201 { get => diemEE201; set => diemEE201 = value; }
        public double DiemEE205 { get => diemEE205; set => diemEE205 = value; }

        public double DiemTB()
        {
            return (diemEE200 + diemEE201 + diemEE205) / 3;
        }

        public string TinhXepLoai()
        {
            double tb = DiemTB();
            if (tb >= 8) return "Gioi";
            else if (tb >= 6.5) return "Kha";
            else if (tb >= 5) return "Trung Binh";
            else return "Yeu";
        }

        public void Nhap()
        {
            Console.Write("Nhap MSSV: ");
            MSSV = Console.ReadLine();
            Console.Write("Nhap Ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Dia chi: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhap Ngay sinh (dd/MM/yyyy): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaysinh))
            {
                Console.Write("Ngay khong dung dinh dang, nhap lai (dd/MM/yyyy): ");
            }

            Console.Write("Nhap Diem EE200: ");
            DiemEE200 = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem EE201: ");
            DiemEE201 = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem EE205: ");
            DiemEE205 = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"MSSV: {MSSV} | Ho ten: {HoTen} | Dia chi: {DiaChi} | Ngay sinh: {NgaySinh:dd/MM/yyyy}");
            Console.WriteLine($"Diem TB: {DiemTB():F2} | Xep loai: {TinhXepLoai()}");
        }
    }
}
