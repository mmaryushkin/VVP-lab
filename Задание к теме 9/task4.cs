using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("А = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("C = ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nКол-во квадратов, размещенных на прямоугольнике: {a * b / c}\n");
        Console.WriteLine($"Площадь незанятой части прямоугольника: {a * b % c}");
    }
}