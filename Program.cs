using System;
using System.Text;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            BaiTap1();
            BaiTap2();
            Baitap3();
            Baitap4();
            Baitap5();
            Baitap6();
            Baitap7();
            Baitap8();
            Baitap9();
            Baitap10();
        }
        static void BaiTap1()
        {
            Console.WriteLine("===== Kiểm tra số chia hết cho 3 =====");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            string str = $"Số {n} chia hết cho 3";
            if (n % 3 != 0) str = $"Số {n} không chia hết cho 3";
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void BaiTap2()
        {
            Console.WriteLine("===== Hiển thị bảng cửu chương từ 1 đến n =====");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    string str = $"{i} x {j} = {i * j}";
                    Console.WriteLine(str);
                }
            }
            Console.ReadKey();
        }
        static void Baitap3()
        {
            Console.WriteLine("===== Tính tổng giai thừa từ 1 đến n =====");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 2; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void Baitap4()
        {
            Console.WriteLine("===== Kiểm tra số chính phương =====");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            int num = (int)Math.Sqrt(n);
            string str = $"Số {n} là số chính phương";
            if (num * num != n) str = $"Số {n} không phải là số chính phương";
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void Baitap5()
        {
            Console.WriteLine("===== Hiển thị số ngày có trong tháng =====");
            Console.Write("Nhập tháng bất kỳ: ");
            int month = int.Parse(Console.ReadLine());
            string str;
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    str = $"Tháng {month} có 31 ngày.";
                    break;

                case 4: case 6: case 9: case 11:
                    str = $"Tháng {month} có 30 ngày.";
                    break;

                case 2:
                    str = $"Tháng {month} có 28 hoặc 29 ngày.";
                    break;

                default:
                    str = $"Tháng {month} không hợp lệ";
                    break;
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void Baitap6()
        {
            Console.WriteLine("===== Tính tổng S = 1 + 2^2 + 3^3 + ... + n^n =====");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 2; i <= n; i++)
            {
                sum += i * i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void Baitap7()
        {
            Console.WriteLine("===== Tính tổng các số lẻ từ 1 đến n =====");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void Baitap8()
        {
            Console.WriteLine("===== Kiểm tra số nguyên tố =====");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            string str = $"Số {n} là số nguyên tố";
            if (n < 2)
            {
                str = $"Số {n} không phải là số nguyên tố";
            }
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i != 0) continue;
                str = $"Số {n} không phải là số nguyên tố";
                break;
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
        static void Baitap9()
        {
            Console.WriteLine("===== Hiển thị hình tam giác =====");
            Console.Write("Nhập số hàng n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("----- 1. Tam giác -----");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----- 2. Tam giác ngược -----");
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----- 3. Tam giác đều -----");
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Baitap10()
        {
            Console.WriteLine("===== Tính toãn dãy Fibonacci =====");
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            int p0 = 0;
            int p1 = 1;
            int pn = p0 + p1;
            string str = $"{p0} {p1} {pn}";
            if (n == 1)
            {
                str = $"{p0}";
            }
            if (n == 2)
            {
                str = $"{p0} {p1}";
            }
            for (int i = 3; i < n; i++)
            {
                p0 = p1;
                p1 = pn;
                pn = p0 + p1;
                str += $" {pn}";
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}