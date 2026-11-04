namespace KT11_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int soLuong = Convert.ToInt32(Console.ReadLine());
            List<SinhVien> dssv = new List<SinhVien>();
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write("Nhap ten: ");
                string hoTen = Console.ReadLine();

                Console.Write("Nhap que quan: ");
                string queQuan = Console.ReadLine();

                Console.Write("Nhap Toan: ");
                int T = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap Ly: ");
                int L = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhap Hoa: ");
                int H = Convert.ToInt32(Console.ReadLine());

                SinhVien sv = new SinhVien(hoTen, queQuan, T, L, H);
                dssv.Add(sv);
            }
        }
    }
}
