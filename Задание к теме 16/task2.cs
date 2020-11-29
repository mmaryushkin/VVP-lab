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

        Console.Write("D = ");
        int d = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            arr[i] = a * (int)Math.Pow(d, i);
            Console.Write(arr[i] + " ");
        }
    }   
}