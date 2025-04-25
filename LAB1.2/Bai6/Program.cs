using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        float[] arr = new float[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = float.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        Console.WriteLine("Mang sau khi sap xep tang dan:");
        foreach (float num in arr)
            Console.Write(num + " ");
    }
}
