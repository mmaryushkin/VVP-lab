using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int A = 1;
        int B = 2;

        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}\n");

        int C = A;
        A = B;
        B = C;

        Console.WriteLine("Перестановка...\n");
        Thread.Sleep(3000);
        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");
    }
} 