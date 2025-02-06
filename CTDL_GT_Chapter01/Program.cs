// See https://aka.ms/new-console-template for more information

using System;
using System.Text;

class Program
{
    // Bài 1: Tính S(n) = 1 + 2 + 3 + … + n
    //static void NhapN(out int n)
    //{
    //    while (true)
    //    {
    //        Console.Write(" Mời bạn nhập N: ");
    //        n = int.Parse(Console.ReadLine());
    //        if (n > 0)
    //            break;
    //        Console.WriteLine("Bạn nhập sai, mời bạn nhập lại: ");
    //    }
    //}
    //static int TinhTong(int n)
    //{
    //    int s = 0;
    //    for (int i = 1; i <= n; i++)
    //        s += i;
    //    return s;

    //}
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    NhapN(out int n);
    //    int kq = TinhTong(n);
    //    Console.WriteLine($"Tổng từ 1 đến {n} là {kq}");
    //    Console.ReadKey();
    //}

    //Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2
    //static void NhapN2 (out int n)
    //{
    //    while (true)
    //    {
    //        Console.Write("Mời bạn nhập N: ");
    //        n = int.Parse(Console.ReadLine());
    //        if (n > 0) break;
    //        Console.WriteLine("Bạn nhập sai mời bạn nhập lại");
    //    }
    //}
    //static int TinhTongLuyThua (int n)
    //{
    //    int s = 0;
    //    for (int i = 1;i <= n; i++)
    //    {
    //        s += i*i;
    //    }
    //    return s;
    //}
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    NhapN2(out int n);
    //    int kq = TinhTongLuyThua(n);
    //    Console.WriteLine($"Tổng lũy thừa từ 1 đến {n} là {kq}");
    //    Console.ReadKey();
    //}
    //Bài 3: Tính S(n) = 1 + ½ + 1/3 + … + 1/n
    static void NhapN3(out int n)
    {
        while (true)
        {
            Console.Write(" Mời bạn nhập n: ");
            n = int.Parse(Console.ReadLine());
            if (n > 0) break;
            Console.WriteLine("Bạn nhập sai, mời bạn nhập lại:");
        }
    }
     static double TinhTong


}

