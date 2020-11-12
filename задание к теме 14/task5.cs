using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        while (a != b)
        {
            if (a > b)
                a -= b;

            if (b > a)
                b -= a;
        }

        Console.WriteLine(a);
    }
}