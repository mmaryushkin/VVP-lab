using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Координаты точки: ");
            string[] coordinates = Console.ReadLine().Split();
            float x = float.Parse(coordinates[0]);
            float y = float.Parse(coordinates[1]);
            Console.WriteLine(Quarter(x, y));
        }
    }


    static int Quarter(float x, float y)
    {
        if (x > 0 && y > 0)
            return 1;

        if (x < 0 && y > 0)
            return 2;

        if (x < 0 && y < 0)
            return 3;

        if (x > 0 && y < 0)
            return 4;

        return 0;
    }
}