using System;
class Program
{
    static void Main(string[] args)
    {
        //?? Toán tử hợp nhất
        //int? x = null;
        //int y = x ?? 100; // nếu x là null thì y sẽ là giá trị 100
        // console.WriteLine(y);
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Khai báo biến
        string? ten;
        int tuoi;
        //nhập dữ liệu vào bàn phím
        Console.Write("Nhập tên: ");
        ten = Console.ReadLine();
        Console.Write("Nhập tuổi: ");
        tuoi = int.Parse(Console.ReadLine() ?? "0");
        //Xuất ra màn hình 
        //Console.WriteLine(“Xin chào “ + ten+”, bạn “+tuổi+ “tuổi”);
        //Cách xuất khác
        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
    }
}
