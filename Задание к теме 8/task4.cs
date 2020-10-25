using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите двузначное число: ");
        int a = int.Parse(Console.ReadLine());

        while (a > 0)
        {
            Console.Write(a % 10);
            a /= 10;
        }
    }
}