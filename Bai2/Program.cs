using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        double chieuDai, chieuRong;

        Console.Write("Nhập chiều dài: ");
        while (!double.TryParse(Console.ReadLine(), out chieuDai) || chieuDai <= 0)
        {
            Console.Write("Chiều dài không hợp lệ. Nhập lại: ");
        }

        Console.Write("Nhập chiều rộng: ");
        while (!double.TryParse(Console.ReadLine(), out chieuRong) || chieuRong <= 0)
        {
            Console.Write("Chiều rộng không hợp lệ. Nhập lại: ");
        }

        double dienTich = chieuDai * chieuRong;

        Console.WriteLine($"Diện tích hình chữ nhật là: {dienTich}");
        Console.ReadKey();
    }
}
