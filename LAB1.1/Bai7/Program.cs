using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập một năm: ");
        int nam = int.Parse(Console.ReadLine() ?? "0");

        bool laNamNhuan = (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);

        if (laNamNhuan)
            Console.WriteLine($"{nam} là năm nhuận.");
        else
            Console.WriteLine($"{nam} không phải là năm nhuận.");

        Console.ReadKey();
    }
}
