using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Функция: y = 3x^6 - 6x^2 - 7\n");
        Console.Write("Введите х: ");
        
        double x = double.Parse(Console.ReadLine());
        double y = Funct(x);
        Console.WriteLine($"\ny = {y}");
    }
    

    static double Funct(double x)
    {
        // y = 3x^6 − 6x^2 − 7
        double ans = 3 * Math.Pow(x, 6) - 6 * x*x - 7;
        return ans;
    }
}