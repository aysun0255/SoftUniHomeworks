using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 9. Sum of n Numbers
 * Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
 * Note that you may need to use a for-loop.
 */

class SumOfNNnumbers
{
    static void Main()
    {
        Console.Write("How many numbers you want to sum(n):");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum of enterd numbers is:{0}",sum);

    }
}

