using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Функция: y = 4(x−3)^6 − 7(x−3)^3 + 2");
        Console.Write("Введите х: ");

        double x = double.Parse(Console.ReadLine());
        double y = Funct(x);
        Console.WriteLine($"\ny = {y}");
    }

    // y = 4(x−3)^6 − 7(x−3)^3 + 2
    static double Funct(double x) => 4 * Math.Pow(x-3, 6) - 7 * Math.Pow(x-3, 3) + 2; 
}