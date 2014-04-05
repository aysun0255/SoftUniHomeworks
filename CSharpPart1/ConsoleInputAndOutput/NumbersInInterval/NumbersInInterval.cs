using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 11.* Numbers in Interval Dividable by Given Number
 * Write a program that reads two positive integer numbers and prints how many numbers p exist between them such
 * that the reminder of the division by 5 is 0
 */

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Interval start:");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Interval end:");
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        List<int> numbers = new List<int>();
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
                numbers.Add(i);
            }
        }
        Console.WriteLine("There are {0} numbers divisible by 5 in given interval.",p);
        Console.Write("They are:");
        foreach (var number in numbers)
        {
            Console.Write(number+" ");
        }
    }
}

