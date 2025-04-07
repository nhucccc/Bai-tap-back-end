using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số thứ nhất: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập số thứ hai: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Tổng: {a + b}");
        Console.WriteLine($"Tích: {a * b}");

        Console.ReadKey();
    }
}
