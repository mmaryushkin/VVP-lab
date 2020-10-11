using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Известно, что X кг конфет стоит A рублей.");
        Console.Write("X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("A = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Y = ");
        double y = double.Parse(Console.ReadLine());

        double one = a / x;
        double s = one * y;
    
        Console.Write("1 кг конфет: ");
        Console.WriteLine(one);
        Console.Write($"{y} кг конфет стоят: ");
        Console.WriteLine(s); 
    }
}