using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.WriteLine(Progression(arr));
    }
    

    static int Progression(int[] arr)
    {
        int d = arr[1] - arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] - arr[i] != d)
                return 0;
        }
        return d;
    }
}