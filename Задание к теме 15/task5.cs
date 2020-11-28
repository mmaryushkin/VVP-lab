using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fact2(n));
    }


    static float Fact2(int n)
    {
        float f = 1f;
        for (int i = 1; i <= n; i += 2)
            f *= i;
        return f;
    }      
}