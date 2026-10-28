using System;

namespace TachDaySo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap day so
            Console.Write("Nhap so phan tu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i}] = ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Tach day
            int[] B = new int[n];
            int[] C = new int[n];
            int h = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    B[h] = A[i];
                    h += 1; 
                }
                else if (A[i] < 0)
                {
                    C[k] = A[i];
                    k += 1;
                }
            }

            //In day
            if (h!=0)
            {
                Console.Write("B = ");
                for (int i = 0; i < h; i++)
                {
                    Console.Write(B[i]);
                }
                Console.Write('\n');
            }
            else
            {
                Console.WriteLine("Day B khong co gia tri");
            }

            if (k != 0)
            {
                Console.Write("C = ");
                for (int i = 0; i < k; i++)
                {
                    Console.Write(C[i]);
                    Console.Write(' ');
                }
                Console.Write('\n');
            }
            else
            {
                Console.WriteLine("Day C khong co gia tri");
            }
        }
    }
}
