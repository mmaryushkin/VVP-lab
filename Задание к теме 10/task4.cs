using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int e = n % 10; // разряд единиц
        int d = n / 10 % 10; // разряд десятков
        int c = n / 100; // разряд сотен

        if (e < d && d < c)
        {
            Console.WriteLine("Цифры числа образуют убывающую последовательность");
        }

        else if (c < d && d < e)
        {
            Console.WriteLine("Цивры образуют возрастающую последовательность");
        }
    }
}