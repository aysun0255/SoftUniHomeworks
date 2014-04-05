using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 7. Sort 3 Numbers with Nested Ifs
 * Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements.
 * Don’t use arrays and the built-in sorting functionality
 */

class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c:");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine(a);
                if (c > b)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }

            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine(b);
                if (a < c)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }

            }
            else
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }

    }
}

