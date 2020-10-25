using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Размер файла в байтах: ");
        int byteSize = int.Parse(Console.ReadLine());

        int kylobSize = byteSize / 8;
        Console.WriteLine($"\nРазмер файла в килобайтах: {kylobSize}"); 
    }
}