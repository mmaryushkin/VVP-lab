using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int s = 1;
        int k = 2;
        while (s + k < n)
        {
            s += k;
            k++;
        }
        Console.WriteLine(k);
    }
}