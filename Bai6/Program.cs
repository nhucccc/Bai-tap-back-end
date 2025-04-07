using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập một số: ");
        double so = double.Parse(Console.ReadLine() ?? "0");

        if (so > 0)
            Console.WriteLine("Đây là số dương.");
        else if (so < 0)
            Console.WriteLine("Đây là số âm.");
        else
            Console.WriteLine("Đây là số 0.");

        Console.ReadKey();
    }
}
