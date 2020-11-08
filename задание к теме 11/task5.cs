using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());
        
        if (a == 0)
            Console.WriteLine("Нулевое число");

        if (a > 0 && a % 2 == 0)
            Console.WriteLine("Положительное четное число");

        if (a > 0 && a % 2 != 0)
            Console.WriteLine("Положительное нечетное число");

        if (a < 0 && a % 2 == 0)
            Console.WriteLine("Отрицательное четное число");

        if (a < 0 && a % 2 != 0)
            Console.WriteLine("Отрицательное нечетное число");
    }
}