using System;

class Program
{
    static int TimSoLonThuHai(int[] arr)
    {
        int max = int.MinValue, second = int.MinValue;

        foreach (int x in arr)
        {
            if (x > max)
            {
                second = max;
                max = x;
            }
            else if (x > second && x != max)
            {
                second = x;
            }
        }

        return second;
    }

    static void Main()
    {
        int[] arr = { 4, 7, 9, 2, 10, 8 };
        Console.WriteLine("So lon thu hai: " + TimSoLonThuHai(arr));
    }
}
