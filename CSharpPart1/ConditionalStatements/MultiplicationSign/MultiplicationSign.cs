using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 4. Multiplication Sign
 * Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a
 * sequence of if operators.
 */

class MultiplicationSign
{
    static void Main()
    {
        //enter three numbers to check sign of their multiplication
        Console.Write("a:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("b:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("c:");
        double thirdNumber = double.Parse(Console.ReadLine());


        if (firstNumber >= 0 && secondNumber >= 0 && thirdNumber >= 0)
        {
            Console.WriteLine("Sign of product is +");
        }
        else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
        {
            Console.WriteLine("Sign of product is -");
        }
        else
        {
            Console.WriteLine("result: 0");
        }
    }
}

