using System;
using System.Threading;

namespace Project
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int A = 1;
            int B = 2;
            int C = 3;

            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            Console.WriteLine($"C = {C}\n");
            /*----------------------------
            A = B = 2;
            B = C = 3;
            C = A = 1;
            ----------------------------*/
            int Z = A; // 1
            A = B; // 2
            B = C; // 3
            C = Z; // 1

            Console.WriteLine("Перестановка...\n");
            Thread.Sleep(3000);

            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
            Console.WriteLine($"C = {C}");
        }
    }
}