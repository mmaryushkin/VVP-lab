using System;

class Program
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        Console.Write("The year of ");
        switch (year / 12 % 5)
        {
            case 0:
                Console.Write("green ");
                break;
            case 1:
                Console.Write("red ");
                break;
            case 2:
                Console.Write("yellow ");
                break;
            case 3:
                Console.Write("white ");
                break;
            case 4:
                Console.Write("black ");
                break;
        }
        switch ((year + 8) % 12)
        {
            case 0:
                Console.Write("rat ");
                break;
            case 1:
                Console.Write("cow ");
                break;
            case 2:
                Console.Write("tiger ");
                break;
            case 3:
                Console.Write("rabbit ");
                break;
            case 4:
                Console.Write("dragon ");
                break;
            case 5:
                Console.Write("snake ");
                break;
            case 6:
                Console.Write("horse ");
                break;
            case 7:
                Console.Write("sheep ");
                break;
            case 8:
                Console.Write("monkey ");
                break;
            case 9:
                Console.Write("chicken ");
                break;
            case 10:
                Console.Write("dog ");
                break;
            case 11:
                Console.Write("pig ");
                break;
        }
    }
}