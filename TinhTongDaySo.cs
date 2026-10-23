using System;

namespace NhapDaySo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i <= n-1; i++)
            {
                Console.Write($"A[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            int sum = 0;
            for (int i = 0; i <= n-1; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Tong day so = {sum}");
        }
    }
}
