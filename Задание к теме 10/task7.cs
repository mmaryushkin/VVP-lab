using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine()); // 1-я сторона

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine()); // 2-я сторона

        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine()); // 3-я сторона

        bool firstCond = (a + b > c);
        bool secondCond = (b + c > a);
        bool thirdCond = (c + a > b);

        Console.WriteLine($"Существует треугольник с данными сторонами: {firstCond && secondCond && thirdCond}");
    }
}