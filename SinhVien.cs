using System;
using System.Collections.Generic;
using System.Text;

namespace KT11_4
{
    public class SinhVien
    {
        public string HoTen;
        public string QueQuan;
        public double Toan;
        public double Ly;
        public double Hoa;
        public double Diem;
        

        public SinhVien (string hoTen, string queQuan, double diemToan, double diemLy, double diemHoa)
        {
            HoTen = hoTen;
            QueQuan = queQuan;
            Toan = diemToan;
            Ly = diemLy;
            Hoa = diemHoa;
        }

        public void TinhDiemTrungBinh()
        {
            Diem =  (Toan + Ly + Hoa) / 3;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Ten: {HoTen}\t Diem TB: {Diem}\n");
        }
    }
}
