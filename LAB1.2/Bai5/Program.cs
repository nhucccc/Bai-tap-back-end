using System;

class Program
{
    static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.Write("Nhap a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b = ");
        int b = int.Parse(Console.ReadLine());

        HoanVi(ref a, ref b);
        Console.WriteLine($"Sau khi hoan vi: a = {a}, b = {b}");
    }
}
