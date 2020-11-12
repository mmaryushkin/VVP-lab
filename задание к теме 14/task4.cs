using System;

class Program
{
    static void Main(string[] args)
    {
        float v = 1000f; // начальный вклад
        float p = float.Parse(Console.ReadLine()); // проценты
        int k = 0; // счетчик месяцев
        while (v <= 1100)
        {
            v += v * p / 100;
            k++;
        }
        Console.WriteLine("Количество месяцев " + k);
        Console.WriteLine("Размер вклада " + v);
    }
}