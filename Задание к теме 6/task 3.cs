using System;
using System.Threading;

namespace Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            Console.WriteLine($"C = {C}\n");
            /*----------------------------
            A = B
            B = C
            C = A
            ----------------------------*/
            int Z = A;
            A = B;
            B = C;
            C = Z;

            Console.WriteLine("Перестановка...\n");
            Thread.Sleep(3000);

            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            Console.WriteLine($"C = {C}");
        }
    }
}