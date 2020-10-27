using System;

class Program
{
    static void Main(string[] args)
    {
        // 1 января - 0
        int k = int.Parse(Console.ReadLine()); // день года
        Console.WriteLine(k % 7); // номер дня недели 
    }
}