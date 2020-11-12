using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(i + " ");
        }
    }
}