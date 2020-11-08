using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Координаты точки А: ");
        string[] arr_A = Console.ReadLine().Split();
        int ax = int.Parse(arr_A[0]);
        int ay = int.Parse(arr_A[1]);

        Console.Write("Координаты точки B: ");
        string[] arr_B = Console.ReadLine().Split();
        int bx = int.Parse(arr_B[0]);
        int by = int.Parse(arr_B[1]);

        Console.Write("Координаты точки C: ");
        string[] arr_C = Console.ReadLine().Split();
        int cx = int.Parse(arr_C[0]);
        int cy = int.Parse(arr_C[1]);

        double ab = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
        double ac = Math.Sqrt((ax - cx) * (ax - cx) + (ay - cy) * (ay - cy));

        if (ab < ac)
            Console.WriteLine($"B ({bx}; {by}) AB = {ab}");
        else
            Console.WriteLine($"C ({cx}; {cy}) AC = {ac}");
    }
}