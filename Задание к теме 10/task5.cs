using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        bool palindrom = (n == Reverse(n));

        Console.WriteLine($"Число одинаково читается слева направо и справа налево: {palindrom}");
    }

    static int Reverse(int n)
    {
        int r = 0;
        
        while (n > 0)
        {
            r = r * 10 + n % 10;
            n /= 10;
        }

        return r;
    }
}