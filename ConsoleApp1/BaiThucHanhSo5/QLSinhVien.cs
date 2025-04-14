using System;
using System.Collections.Generic;

namespace BaiThucHanhSo5
{
    class QLSinhVien
    {
        private List<SinhVienKCNTT> dsSinhVienCNTT = new List<SinhVienKCNTT>();
        private List<SinhVienDienTu> dsSinhVienDT = new List<SinhVienDienTu>();

        public void Nhap()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Sinh vien thu {i + 1}, chon loai (C = CNTT, D = Dien Tu): ");
                string chon = Console.ReadLine().Trim().ToUpper();

                if (chon == "C")
                {
                    SinhVienKCNTT sv = new SinhVienKCNTT();
                    sv.Nhap();
                    dsSinhVienCNTT.Add(sv);
                }
                else if (chon == "D")
                {
                    SinhVienDienTu sv = new SinhVienDienTu();
                    sv.Nhap();
                    dsSinhVienDT.Add(sv);
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le, bo qua sinh vien nay.");
                }
            }
        }

        public void Xuat()
        {
            Console.WriteLine("\n--- Danh sach sinh vien CNTT ---");
            int gioi = 0, kha = 0, tb = 0, yeu = 0;
            foreach (var sv in dsSinhVienCNTT)
            {
                sv.Xuat();
                switch (sv.TinhXepLoai())
                {
                    case "Gioi": gioi++; break;
                    case "Kha": kha++; break;
                    case "Trung Binh": tb++; break;
                    case "Yeu": yeu++; break;
                }
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine("\n--- Danh sach sinh vien Dien Tu ---");
            foreach (var sv in dsSinhVienDT)
            {
                sv.Xuat();
                switch (sv.TinhXepLoai())
                {
                    case "Gioi": gioi++; break;
                    case "Kha": kha++; break;
                    case "Trung Binh": tb++; break;
                    case "Yeu": yeu++; break;
                }
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine($"\n=> Tong ket: Gioi: {gioi}, Kha: {kha}, Trung Binh: {tb}, Yeu: {yeu}");
        }
    }
}
