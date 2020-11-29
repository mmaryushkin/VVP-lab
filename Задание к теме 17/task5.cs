using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int k = 0; k < n; k++)
        {
            arr[k] = int.Parse(Console.ReadLine());
        }

        int i = 0;
        int j = n - 1;
        while (i != j)
        {
            if (arr[i] == arr[j])
                Console.WriteLine($"{i}, {j}");
            i++;
            j--;
        }
    }
}