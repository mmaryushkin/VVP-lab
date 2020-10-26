using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n % 60);
    }
}