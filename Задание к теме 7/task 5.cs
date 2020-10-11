using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        ax + b = 0
        ax = -b
        x = -b/a
        */
        Console.WriteLine("Уравнение 5x + 10 = 0: ");
        
        int a = 5;
        int b = 10;
        int x = -b / a;

        Console.WriteLine($"x = {x}");
    }
}