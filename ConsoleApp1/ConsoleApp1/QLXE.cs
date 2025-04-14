using System;
using System.Globalization;

namespace QLXE
{
    class Xe
    {
        // Khai báo các trường private
        private string bienso;
        private string tenxe;
        private int trongtai;
        private DateTime ngaydangkiem;
        private int tieuchuanbang;

        // Phương thức nhập thông tin xe
        public void Nhap()
        {
            Console.Write("Nhap bien so xe: ");
            bienso = Console.ReadLine();

            Console.Write("Nhap ten xe: ");
            tenxe = Console.ReadLine();

            Console.Write("Nhap trong tai (kg): ");
            while (!int.TryParse(Console.ReadLine(), out trongtai))
            {
                Console.Write("Vui long nhap so nguyen hop le cho trong tai: ");
            }

            Console.Write("Nhap ngay dang kiem (dd/MM/yyyy): ");
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaydangkiem))
            {
                Console.Write("Ngay khong hop le. Nhap lai (dd/MM/yyyy): ");
            }

            Console.Write("Nhap tieu chuan bang (so): ");
            while (!int.TryParse(Console.ReadLine(), out tieuchuanbang))
            {
                Console.Write("Vui long nhap so nguyen hop le cho tieu chuan bang: ");
            }
        }

        // Phương thức xuất thông tin xe
        public void Xuat()
        {
            Console.WriteLine("\n--- Thong Tin Xe ---");
            Console.WriteLine("Bien so: " + bienso);
            Console.WriteLine("Ten xe: " + tenxe);
            Console.WriteLine("Trong tai: " + trongtai + " kg");
            Console.WriteLine("Ngay dang kiem: " + ngaydangkiem.ToString("dd/MM/yyyy"));
            Console.WriteLine("Tieu chuan bang: " + tieuchuanbang);
        }
    }

    class QLXE
    {
        static void Main(string[] args)
        {
            Xe xe = new Xe();

            Console.WriteLine("--- NHAP THONG TIN XE ---");
            xe.Nhap();

            Console.WriteLine("\n--- XUAT THONG TIN XE ---");
            xe.Xuat();

            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}
