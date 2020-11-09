﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] numbers = {"десять", "одинадцать", "двенадцать",
        "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать",
        "восемнадцать", "девятнадцать", "двадцать", "двадцать одно", "двадцать два",
        "двадцать три", "двадцать четыре", "двадцать пять", "двадцать шесть", "двадцать семь",
        "двадцать восемь", "двадцать девять", "тридцать", "тридцать одно", "тридцать два", "тридцать три",
        "тридцать четыре", "тридцать пять", "тридцать шесть", "тридцать семь", "тридцать восемь", "тридцать девять", "сорок"};

        int n = int.Parse(Console.ReadLine());
        int index = (n-10) % 31;

        if (n == 21 || n == 31)
            Console.WriteLine($"{numbers[index]} учебное заведение");
        else
            Console.WriteLine($"{numbers[index]} учебных заведений");
    }
}