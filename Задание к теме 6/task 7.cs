using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите А: ");
        int A = int.Parse(Console.ReadLine());

        int b = A*A; // A^2
        int c = b * A; // A^3
        b *= c; // A^5
        c = b;
        b *= b; // A^10
        b *= c; // A^15
        
        Console.WriteLine($"A^8 = {b}");
    }
}