using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double doC;

        Console.Write("Nhập nhiệt độ (°C): ");
        while (!double.TryParse(Console.ReadLine(), out doC))
        {
            Console.Write("Giá trị không hợp lệ. Nhập lại (°C): ");
        }

        double doF = (doC * 9 / 5) + 32;

        Console.WriteLine($"→ {doC}°C = {doF}°F");
        Console.ReadKey();
    }
}

