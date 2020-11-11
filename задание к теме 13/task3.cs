using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int n2 = 0;
        for (int i = n; i > 0; i--)
            n2 += 2 * i - 1;
        Console.WriteLine(n2);
    }
}