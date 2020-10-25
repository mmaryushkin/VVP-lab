using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write(a % 100);
        Console.Write(a / 100);
    }
}