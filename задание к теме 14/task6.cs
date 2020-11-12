using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int c = 1;
        int fib1 = 1;
        int fib2 = 1;
        int fib = 0;
        for (int i = 1; i < n; i++)
        {
            fib = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib;
            c++;
        }
        Console.WriteLine(c);
    }
}