using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = i + 1;


        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("L = ");
        int l = int.Parse(Console.ReadLine());

        float s = 0;
        for (int i = k; i < l; i++)
            s += arr[i];

        Console.WriteLine(s / (float)(l - k));
    }   
}