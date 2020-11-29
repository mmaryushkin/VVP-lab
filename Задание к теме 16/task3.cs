using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        arr[0] = a;

        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        arr[1] = b;

        for (int i = 2; i < n; i++)
            arr[i] = arr[i - 1] + arr[i - 2];

        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
    }   
}