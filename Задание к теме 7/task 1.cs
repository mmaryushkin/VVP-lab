using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение угла в градусах: ");
        int deg = int.Parse(Console.ReadLine());

        double rad = (deg * Math.PI) / 180;
        Console.WriteLine($"\nЗначение угла в радианах равно: {rad}"); 
    }
}