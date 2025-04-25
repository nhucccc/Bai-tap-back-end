using System;

class Program
{
    static int TinhTongSoChan(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
            if (num % 2 == 0)
                sum += num;
        return sum;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Tong cac so chan: " + TinhTongSoChan(arr));
    }
}
