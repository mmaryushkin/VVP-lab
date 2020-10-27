using System;

class Program
{
    static void Main(string[] args)
    {
        int[] days = { 7, 1, 2, 3, 4, 5, 6 };
        
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine()); // 1 января

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine()); // день года

        Console.WriteLine(days[(k + n-1) % 7]);
    }
}