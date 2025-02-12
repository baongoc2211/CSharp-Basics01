// See https://aka.ms/new-console-template for more information

using System;
using System.Text;

class Program
{
    #region Bài 1: Tính S(n) = 1 + 2 + 3 + … + n
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
    #endregion
    #region Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2
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
    #endregion
    #region Bài 3: Tính S(n) = 1 + ½ + 1/3 + … + 1/n
    //static void NhapN3(out int n)
    //{
    //    while (true)
    //    {
    //        Console.Write(" Mời bạn nhập n: ");
    //        n = int.Parse(Console.ReadLine());
    //        if (n > 0) break;
    //        Console.WriteLine("Bạn nhập sai, mời bạn nhập lại:");
    //    }
    //}
    //static double TinhTong(int n)
    //{

    //    double s = 0;
    //    for (int i = 1; i <= n; i++)
    //        s += 1.0 / i;
    //    return s;
    //}
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    NhapN3(out int n);
    //    double kq = TinhTong(n);
    //    Console.WriteLine($"Tổng từ 1 đến 1/{n} là {kq}");
    //    Console.ReadKey();
    //}
    #endregion
    #region Bài 4: Tính S(n) = ½ + ¼ + … + 1/2n
    //static void NhapN(out int n)
    //{

    //    while (true)
    //    {
    //        Console.Write("Mời bạn nhập n: ");
    //        n = int.Parse(Console.ReadLine());
    //        if (n > 0) break;
    //        Console.WriteLine("Bạn nhập sai, mời bạn nhập lại: ");
    //    }
    //}
    //static double TinhTong(int n)
    //{
    //    double s = 0;
    //    for (int i = 1; i <= n; i++)
    //        s += 1.0 / (2 * i);
    //    return s;
    //}
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    NhapN(out int n);
    //    double kq = TinhTong(n);
    //    Console.WriteLine($"Tổng từ 1/2 đến 1/{2 * n} là {kq}");
    //}
    #endregion
    #region Bài 5: Tính 1 + 1/3 + 1/5 + … + 1/(2n + 1)
    //static void Nhap(out int n)
    //{
    //    while (true)
    //    {
    //        Console.WriteLine(" Mời bạn nhập N ");
    //        n = int.Parse(Console.ReadLine());
    //        if (n > 0) break;
    //        Console.WriteLine(" Bạn nhập sai, mời bạn nhập lại");
    //    }
    //}
    //static double TinhTong(int n)
    //{
    //    double s = 0;
    //    int i = 0;
    //    while (i < n)
    //    {
    //        s = s + 1.0 / (2 * i + 1);
    //        i++;
    //    }
    //    return s;
    //}
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    Nhap(out int n);
    //    double kq = TinhTong(n);
    //    Console.WriteLine($"Tổng các phân tử là s({n}) = {kq}");
    //    Console.ReadKey();
    //}
    #endregion
    #region Bài 6: Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)
    //static void Nhap(out int n)
    //{
    //    while (true)
    //    {
    //        Console.Write(" Mời bạn nhập n:");
    //        n = int.Parse(Console.ReadLine());
    //        if( n > 0) break;
    //        Console.WriteLine(" Bạn nhập sai, mời bạn nhập lại");
    //    }
    //}
    //static double TinhTong(int n)
    //{
    //    double s = 0;
    //    for ( int i = 1; i <= n; i++)
    //        s += 1.0 / (i * (i + 1));
    //    return s;
    //}
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    Nhap(out int n);
    //    double kq = TinhTong(n);
    //    Console.WriteLine($"Tổng các phần tử là s({n}) = {kq}");
    //    Console.ReadKey();
    //}
    #endregion
    #region Bài 7: Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1
    //static void Nhap(out int n)
    //{
    //    while (true)
    //    {
    //        Console.Write("Mời bạn nhập n: ");
    //        n = int.Parse(Console.ReadLine());
    //        if (n > 0) break;
    //        Console.WriteLine(" Bạn nhập sai, mời bạn nhập lại");
    //    }
    //}
    //static double TinhTong(int n)
    //{
    //    double s = 0;
    //    for (int i = 1; i <= n; i++)
    //        s += (double) i / (i + 1);
    //    return s;
    //}
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    Nhap(out int n);
    //    double kq = TinhTong(n);
    //    Console.WriteLine($"Tổng các phần tử là s({n}) = {kq}");
    //    Console.ReadKey();
    //}
    #endregion
    #region Bài 8: Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2
    //static void Nhap(out int n)
    //{
    //    while (true)
    //    {
    //        Console.Write("Moi bạn nhập n: ");
    //        n = int.Parse(Console.ReadLine());
    //        if (n > 0) break;
    //        Console.WriteLine(" Bạn nhập sai, mời bạn nhập lại");
    //    }
    //}
    //static double TinhTong(int n)
    //{
    //    double s = 0;
    //    for (int i = 0; i < n; i++)
    //        s += (double)(2 * i + 1) / (2 * i + 2);
    //    return s;
    //}
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    Nhap(out int n);
    //    double kq = TinhTong(n);
    //    Console.WriteLine($"Tổng các phần tử là s({n}) = {kq}");
    //    Console.ReadKey();
    //}
    #endregion
    #region Bài 9: Tính T(n) = 1 x 2 x 3…x N
    //static void Nhap(out ulong n)
    //{
    //    while (true)
    //    {
    //        Console.Write("Mời bạn nhập n: ");
    //        n = ulong.Parse(Console.ReadLine());
    //        if (n > 0) break;
    //        Console.WriteLine(" Bạn nhập sai, mời bạn nhập lại");
    //    }
    //}
    //static double TinhTich(ulong n)
    //{
    //    ulong t = 1;
    //    ulong i = 1;
    //    while (i <= n)
    //    {
    //        t *= i;
    //        i++;
    //    }
    //    return t;
    //}
    //static void Main(string[] args)
    //{

    //    Console.OutputEncoding = Encoding.Unicode;
    //    Console.InputEncoding = Encoding.Unicode;
    //    Nhap(out ulong n);
    //    double kq = TinhTich(n);
    //    Console.WriteLine($"Tích các phần tử là s({n}) = {kq}");
    //    Console.ReadKey();
    //}
    #endregion
    #region Bài 10: Tính T(x, n) = x^n
    //static void NhapM(out int n)
    //{
    //    while (true)
    //    {
    //        Console.Write("Mời bạn nhập n: ");
    //        n = int.Parse(Console.ReadLine());
    //        if (n > 0) break;
    //        Console.WriteLine(" Bạn nhập sai, mời bạn nhập lại");
    //    }
    //}
    //static void NhapX(out int x)
    //{

    //    while (true)
    //    {
    //        Console.Write("Mời bạn nhập x: ");
    //        x = int.Parse(Console.ReadLine());
    //        if (x > 0) break;
    //        Console.WriteLine(" Bạn nhập sai, mời bạn nhập lại");
    //    }
    //}
    //static double TinhTich(int x, int n)
    //{
    //    double t = 1;
    //    for (int i = 1; i <= n; i++)
    //        t *= x;
    //    return t;
    //}
    #endregion
}





