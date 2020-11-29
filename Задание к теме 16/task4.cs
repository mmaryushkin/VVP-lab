using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int j = 0; j < n; j++)
            arr[j] = j + 1;

        for (int i = 0; i < n / 2; i++)
            Console.Write(arr[i] + " " + arr[n - 1 - i] + " ");

        if (n % 2 == 1)
            Console.Write(arr[n / 2]);
    }   
}