using System;

class Program
{
    static void Main(string[] args)
    {
        string[] days = { "Воскресенье", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };

        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(days[k % 7]);
    }
}