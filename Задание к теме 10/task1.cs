using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        bool inequality = (a > 2 && b <= 3);
        Console.WriteLine($"Высказывание «Справедливы неравенства A > 2 и B ≤ 3»: {inequality}");
    }
}