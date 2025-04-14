using System;
using System.Globalization;

namespace BaiThucHanhSo5
{
    class SinhVienDienTu
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DiemEE200 { get; set; }
        public double DiemEE201 { get; set; }
        public double DiemEE205 { get; set; }

        public double DiemTB()
        {
            return (DiemEE200 + DiemEE201 + DiemEE205) / 3;
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
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ns))
            {
                Console.Write("Ngay khong dung dinh dang, nhap lai (dd/MM/yyyy): ");
            }
            NgaySinh = ns;

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
