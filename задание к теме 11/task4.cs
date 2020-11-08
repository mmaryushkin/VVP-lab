using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Координаты точки: ");
        string[] arr = Console.ReadLine().Split();
        int x = int.Parse(arr[0]);
        int y = int.Parse(arr[1]);

        if (x > 0 && y > 0)
            Console.WriteLine("1-я четверть");

        if (x < 0 && y > 0)
            Console.WriteLine("2-я четверть");

        if (x < 0 && y < 0)
            Console.WriteLine("3-я четверть");

        if (x > 0 && y < 0)
            Console.WriteLine("4-я четверть");
    }
}