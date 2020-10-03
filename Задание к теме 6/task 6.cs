using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите А: ");
        int A = int.Parse(Console.ReadLine());
        
        int b = A*A; // A^2
        b *= A*A; // A^4
        b *= b; // A^8

        Console.WriteLine($"A^8 = {b}");
    }
}