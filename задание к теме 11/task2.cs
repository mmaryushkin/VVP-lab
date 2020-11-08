using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
    
        int maximum = Max(c, Max(a, b)); // максимальное число из трех

        if (maximum == a)
            Console.WriteLine(a + Max(b, c)); // сумма а и максимального из b и с

        if (maximum == b)
            Console.WriteLine(b + Max(a, c)); // сумма b и максимального из a и с
        
        if (maximum == c)
            Console.WriteLine(c + Max(a, b)); // сумма с и максимального из a и b
    }    

    static int Max(int a, int b)
    {
        if (a > b)
            return a;

        return b;
    }
}