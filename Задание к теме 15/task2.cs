using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(Sign(x));
    }


    static int Sign(double x)
    {
        if (x < 0)
            return -1;
        
        if (x == 0)
            return 0;
        
        return 1;
    }
}