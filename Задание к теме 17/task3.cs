using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] > max)
                max = arr[i];
        }

        int min = max;
        for (int i = 2; i < n; i += 2)
        {
            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine(min);
    }
}