using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double p = 1.0;

        for (int i = 1; i <= n; i++)
        {
            p *= 1 + (double)i / 10;
        }

        Console.WriteLine(p);
    }
}