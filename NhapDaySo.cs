using System;

namespace NhapDaySo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i}] =");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
