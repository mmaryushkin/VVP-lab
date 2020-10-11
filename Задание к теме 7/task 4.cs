using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Скорость первого автомобиля: ");
        int v1 = int.Parse(Console.ReadLine());
        
        Console.Write("Скорость второго автомобиля: ");
        int v2 = int.Parse(Console.ReadLine());
        
        Console.Write("S = ");
        int s = int.Parse(Console.ReadLine());
        
        Console.Write("T = ");
        int t = int.Parse(Console.ReadLine());
        
        s += v1*t + v2*t;
        Console.WriteLine($"\n{s} км");
    }
}