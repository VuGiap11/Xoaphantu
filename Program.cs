using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace xoaphantu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr ;
            int n = 0;
            NhapMang(out arr, n);
            int k;
            NhapK(out k, arr.Length);
            Console.WriteLine("Mang goc: ");
            HienMang(arr, arr.Length);
            Console.WriteLine("mang sau khi xoa : ");
            xoaphantu(arr, k);
            HienMang(arr, arr.Length - 1);


            Console.ReadKey();

        }
        private static void xoaphantu(int[] arr, int k)
        {
            for (int i = k; i < arr.Length; i++)
            {
                arr[i] = arr[i] + 1 ;
            }
        }
         private static void NhapK(out int k, int n)
        {
            k = -1;
            while (k < 0 || k >= n)
            {
                Console.WriteLine($"nhap 0 <k <={n}");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void HienMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();    
        }
        private static void NhapMang(out int[] arr, int n)
        {
            Console.WriteLine("Nhap vao phan tu mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"phan tu thu {i} = ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());

                }
            }
            else
            {
                Console.WriteLine("nhap so phan tu mang > 0");
                arr = null;
            }

        }
    }
}
