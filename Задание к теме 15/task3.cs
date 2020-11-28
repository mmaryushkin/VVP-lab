using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Внешний радиус = ");
            float r1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.Write("Внутренний радиус = ");
            float r2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine(RingS(r1, r2) + "\n");
        }
    }

    static float RingS(float r1, float r2) => (float) Math.PI * (r1 * r1 - r2 * r2);
}