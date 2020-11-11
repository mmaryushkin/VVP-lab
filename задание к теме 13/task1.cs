using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (float i = 0.1f; i < 1; i += 0.1f)
        {
            Console.WriteLine(n * i);
        }
    }
}