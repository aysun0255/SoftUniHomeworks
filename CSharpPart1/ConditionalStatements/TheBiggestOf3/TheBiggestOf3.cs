using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 5. The Biggest of 3 Numbers
 * Write a program that finds the biggest of three numbers.
 */


class TheBiggestOf3
{
    static void Main()
    {
        Console.Write("a:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("b:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("c:");
        double thirdNumber = double.Parse(Console.ReadLine());
        double biggest = 0;
       
        if (firstNumber > secondNumber)
        {
            biggest = firstNumber;
        }
        else
        {
            biggest = secondNumber;
        }

        if (biggest < thirdNumber)
        {
            biggest = thirdNumber;
        }

        Console.WriteLine("biggest:{0}",biggest);
    }
}

