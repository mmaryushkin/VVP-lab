﻿using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

class Program
{   
    static void Main(string[] args)
    {
        Console.Write("A = ");
        double a = double.Parse(Console.ReadLine()) * (-1);

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        double s = 0;

        for (int i = 0; i <= n; i++)
            s += Math.Pow(a, i);

        Console.WriteLine(s);
    }
}