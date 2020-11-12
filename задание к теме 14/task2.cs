using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        while (a >= b*2)
            b += b;

        Console.WriteLine("Незанятая часть отрезка А: " + (a - b));
    }
}