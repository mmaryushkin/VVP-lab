using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool statement = (n > 9 && n < 100 && n % 2 == 0);

        Console.WriteLine($"Число двузначное и четное: {statement}"); 
    }
}