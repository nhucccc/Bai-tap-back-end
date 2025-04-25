using System;

class Program
{
    static void DemAmDuong(int[] arr, out int demAm, out int demDuong)
    {
        demAm = demDuong = 0;
        foreach (int num in arr)
        {
            if (num < 0) demAm++;
            else if (num > 0) demDuong++;
        }
    }

    static void Main()
    {
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        DemAmDuong(arr, out int am, out int duong);
        Console.WriteLine($"So am: {am}, So duong: {duong}");
    }
}
