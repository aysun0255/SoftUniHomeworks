using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 10.Fibonacci Numbers
 * Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at
 * a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn
 * how to use loops.
 */

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        int firstNum = 0;
        int secondNum = 1;
        Console.Write(firstNum+" ");
        int temp;
        for (int i = 1; i < n; i++)
        {
            Console.Write(secondNum+" ");
            temp = firstNum;
            firstNum = secondNum;
            secondNum += temp;
            
        }

    }
}

