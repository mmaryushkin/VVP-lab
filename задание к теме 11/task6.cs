using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());

        if (a >= 10 && a <= 99 && a % 2 == 0)
            Console.WriteLine("Четное двузначное число");

        if (a >= 10 && a <= 99 && a % 2 != 0)
            Console.WriteLine("Нечетное двузначное число");

        if (a >= 100 && a <= 999 && a % 2 == 0)
            Console.WriteLine("Четное трехзначное число");

        if (a >= 100 && a <= 999 && a % 2 != 0)
            Console.WriteLine("Нечетное трехзначное число");
    }
}