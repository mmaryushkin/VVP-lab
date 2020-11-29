using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int k = 1;
        
        for (int i = 0; i < n; i++)
        {
            arr[i] = k;
            Console.Write(arr[i] + " ");
            k += 2;
        }
    }   
}