using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение угла в радианах: ");
        double rad = double.Parse(Console.ReadLine());

        double deg = (180 * rad) / Math.PI;
        Console.Write($"\nЗначение угла в градусах равно: {deg}\n");
    }
}