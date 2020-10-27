using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Год: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nВек: {year / 100 + 1}");
    }
}