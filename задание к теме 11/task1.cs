using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a != b)
        {
            if (a > b)
                b = a;
            
            else
                a = b;
        }

        Console.WriteLine($"{a} {b}");
    }    
}