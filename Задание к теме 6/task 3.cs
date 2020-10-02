using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int A = 1;
        int B = 2;
        int C = 3;

        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");
        Console.WriteLine($"C = {C}\n");
        /*------------------------------
        A = C = 3
        B = A = 1
        C = B = 2
        ------------------------------*/
        int Z = A; // 1
        A = C; // 3
        C = B; // 2
        B = Z; // 1

        Console.WriteLine("Перестановка...\n");
        Thread.Sleep(3000);
        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");
        Console.WriteLine($"C = {C}");
    }
} 