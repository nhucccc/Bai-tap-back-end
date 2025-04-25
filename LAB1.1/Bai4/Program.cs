using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập một số nguyên: ");
        int so = int.Parse(Console.ReadLine() ?? "0");

        if (so % 2 == 0)
            Console.WriteLine($"{so} là số chẵn.");
        else
            Console.WriteLine($"{so} là số lẻ.");

        Console.ReadKey();
    }
}
