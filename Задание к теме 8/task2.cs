using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Длина отрезка А: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Длина отрезка В: ");
        int b = int.Parse(Console.ReadLine());

        int n = a / b;
        Console.WriteLine($"\nВ отрезке А {n} отрезков B");
    }
}