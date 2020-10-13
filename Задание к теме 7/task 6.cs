using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        a1*x + b1*y = c1
        a2*x + b2*y = c2

        x = (c1 - b1*y) / a1
        a2 * (c1 - b1*y) / a1 + b2*y = c2

        x = (c1 - b1*y) / a1
        a2/a1 * (c1 - b1*y) + b2*y = c2

        x = (c1 - b1*y) / a1
        c1 - b1*y + b2*y = c2*a1/a2

        x = (c1 - b1*y) / a1
        b2*y - b1*y = c2*a1/a2 - c1

        x = (c1 - b1*y) / a1
        y * (b2 - b1) = c2*a1/a2 - c1

        x = (c1 - b1*y) / a1
        y = (c2*a1/a2 - c1)/(b2 - b1)
        */

        double x; double y;

        int a1 = 2;
        int b1 = 3;
        int c1 = 4;

        int a2 = 3;
        int b2 = 4;
        int c2 = 5;

        y = (c2*a1/a2 - c1)/(b2 - b1);
        x = (c1 - b1*y) / a1;

        Console.WriteLine(x);
        Console.WriteLine(y);

    }
}