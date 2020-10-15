using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");
        Console.WriteLine($"C = {C}\n");
        /*------------------------------
        A = C
        B = A
        C = B
        ------------------------------*/
        int Z = A;
        A = C;
        C = B;
        B = Z;

        Console.WriteLine("Перестановка...\n");
        Thread.Sleep(3000);
        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");
        Console.WriteLine($"C = {C}");
    }
} 