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

        for (int i = 0; i < n; i += 2)
            Console.Write(arr[i] + " ");

        for (int k = n - 2; k > 0; k -= 2)
            Console.Write(arr[k] + " ");
    }   
}