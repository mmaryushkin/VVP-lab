using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] hundreds = { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот",
        "семьсот", "восемьсот", "девятьсот"};

        string[] dozens = {"", "десять", "двадцать", "тридцать", "сорок", "пятьдесят",
        "шестьдесят", "семьдесят", "восемьдесят", "девяносто"};

        string[] units = {"", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        string[] teenageNumbers = { "одинадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
        "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 100 < 20 && n % 100 > 10)
            Console.WriteLine($"{hundreds[n / 100 - 1]} {teenageNumbers[n % 100 - 11]}");
        
        else
            Console.WriteLine($"{hundreds[n / 100 - 1]} {dozens[n % 100 / 10]} {units[n % 100 % 10]}");
    }
}