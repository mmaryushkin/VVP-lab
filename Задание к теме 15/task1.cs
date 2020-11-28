using System;

class Program
{
    static void Main(string[] args)
    {
        float b = 0f; float a;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Введите число: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine(PowerA3(a, b));
        }
    }


    static float PowerA3(float a, float b)
    {
        b = (float) Math.Pow(a, 3);
        return b;
    }
}