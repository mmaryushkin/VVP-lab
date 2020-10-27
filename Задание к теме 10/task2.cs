using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("C = ");
        int c = int.Parse(Console.ReadLine());

        bool inq = (b > a && b < c);
        Console.WriteLine($"A < B < C : {inq}");
    }
}