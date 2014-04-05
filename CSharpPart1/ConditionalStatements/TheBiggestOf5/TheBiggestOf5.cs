using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 6. The Biggest of Five Numbers
 * Write a program that finds the biggest of five numbers by using only five if statements.
 */

class TheBiggestOf5
{
    static void Main()
    {
        Console.Write("a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c:");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d:");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e:");
        double e = double.Parse(Console.ReadLine());
        double biggest = 0;

        if (a>b)
        {
            biggest = a;
        }
        else
        {
            biggest = b;
        }

        if (biggest < c)
        {
            biggest = c;
        }
        
        if (biggest <d)
        {
            biggest = d;
        }
        if (biggest <e)
        {
            biggest = e;
        }

        Console.WriteLine("biggest:{0}",biggest);
    }
}
