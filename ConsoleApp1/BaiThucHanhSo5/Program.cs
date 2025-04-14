using System;

namespace BaiThucHanhSo5
{
    class Program
    {
        static void Main(string[] args)
        {
            QLSinhVien ql = new QLSinhVien();
            ql.Nhap();
            ql.Xuat();

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
