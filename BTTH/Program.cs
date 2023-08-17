using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                LISTFUNCTION();
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        BAITAP1();
                        break;
                    case 2:
                        BAITAP2();
                        break;
                    case 3:
                        BAITAP3();
                        break;
                    case 4:
                        BAITAP4();
                        break;
                    case 5:
                        BAITAP5();
                        break;
                    case 6:
                        BAITAP6();
                        break;
                    case 7:
                        BAITAP7();
                        break;
                    case 8:
                        BAITAP8();
                        break;
                    case 9:
                        BAITAP9();
                        break;
                    case 10:
                        BAITAP10();
                        break;
                }
                bool stop = STOPPROGRAM();
                if (stop) break;
            }
        }
        private static void LISTFUNCTION()
        {
            Console.WriteLine("1.BAITAP1");
            Console.WriteLine("2.BAITAP2");
            Console.WriteLine("3.BAITAP3");
            Console.WriteLine("4.BAITAP4");
            Console.WriteLine("5.BAITAP5");
            Console.WriteLine("6.BAITAP6");
            Console.WriteLine("7.BAITAP7");
            Console.WriteLine("8.BAITAP8");
            Console.WriteLine("9.BAITAP9");
            Console.WriteLine("10.BAITAP10");
            Console.WriteLine("____________");
            Console.WriteLine("MOI BAN CHON BAI TAP");
            return;
        }
        private static bool STOPPROGRAM()
        {
            Console.WriteLine();
            Console.WriteLine(" ban co muon STOPPROGRAM?");
            Console.WriteLine(" nhan phim bat ky de tiep tuc!");
            Console.WriteLine("ESC. DE THOAT CHUONG TRINH");
            ConsoleKeyInfo str = Console.ReadKey();
            if (str.Key == ConsoleKey.Escape)
            {
                return true;
            }
            Console.Clear();
            return false;

        }
        public static int NhapSoNguyen()
        {
            Console.Write("NhapSoNguyen n= ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        private static void BAITAP1()
        {
            int n = NhapSoNguyen();
            if (n % 3 == 0)
            {
                Console.WriteLine("So {0} chia het cho 3", n);
            }
            else
            {
                Console.WriteLine("So {0} khong chia het cho 3", n);
            }
        }
        private static void BAITAP2()
        {
            int n = NhapSoNguyen();
            if (n <= 0)
            {
                Console.WriteLine("Vui long nhap so nguyen duong");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine("{0}x{1}={2}", i, j, i * j);
                    }
                }
            }
        }
        private static void BAITAP3()
        {
            int n = NhapSoNguyen();
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("tong cac so tu 1 den {0} la: {1}", n, sum);
        }
        private static void BAITAP4()
        {
            int n = NhapSoNguyen();
            double num = Math.Sqrt(n);


            if (n < 0 || num != (int)num)
            {
                Console.WriteLine(" so {0} nhap vao khong la so chinh phuong", n);
            }
            else
            {
                Console.WriteLine("so {0} nhap vao la so chinh phuong", n);
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("so {0} nhap vao la = {1}²", n, num);
            }
        }
        private static void BAITAP5()
        {
            int n = NhapSoNguyen();
            Console.Write("NhapNam y= ");
            int y = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("so ngay trong thang {0} la 31 ngay", n);
                    break;
                case 2:
                    if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
                    {
                        Console.WriteLine("so ngay trong thang {0} la 29 ngay", n);
                    }
                    else
                    {
                        Console.WriteLine("so ngay trong thang {0} la 28 ngay", n);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("so ngay trong thang {0} la 30 ngay", n);
                    break;
            }
        }
        private static void BAITAP6()
        {
            int n = NhapSoNguyen();
            double sum = 0;
            if (n <= 0)
            {
                Console.WriteLine("Vui long nhap so nguyen duong");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += Math.Pow(i, i);
                }
                Console.WriteLine("tong cua day so la S= {0}", sum);
            }
        }
        private static void BAITAP7()
        {
            int n = NhapSoNguyen();
            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("tong cac so le tu 1 den {0} la = {1}", n, sum);
        }
        private static void BAITAP9()
        {
            int n = NhapSoNguyen();
            Console.WriteLine("chon hinh dang:");
            Console.WriteLine("1. kieu 1");
            Console.WriteLine("2. kieu 2");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    tamgiacbentrai(n);
                    break;
                case 2:
                    tamgiacbenphai(n);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        private static void tamgiacbentrai(int n)
        {

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        private static void tamgiacbenphai(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
        private static void BAITAP10()
        {
            int n = NhapSoNguyen();
            Console.WriteLine("Day Fibonacci la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.WriteLine();
        }
        private static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        private static void BAITAP8()
        {
            int n = NhapSoNguyen();       
            bool[] isPrime = new bool[n + 1];
            // Khởi tạo mảng thành true
            for (int i = 0; i <= n; i++)
            {
                isPrime[i] = true;
            }
            // Áp dụng thuật toán Sàng của Eratosthenes
            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }
            // In ra số nguyên tố
            Console.WriteLine("day so nguyen to tu 1 den {0} la", n);
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
