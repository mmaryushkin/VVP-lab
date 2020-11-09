using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] directions = { "С", "В", "Ю", "З" };

        Console.Write("Введите направление робота: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Введите команду: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(directions[(c + n) % 4]);
    }
}