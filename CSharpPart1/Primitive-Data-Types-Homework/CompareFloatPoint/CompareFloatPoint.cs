using System;
using System.Threading;
using System.Globalization;


/*
 * 3.Problem 13.* Comparing Floats
 * Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that
 * we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point
 * arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed
 * constant eps. E
 */

class CompareFloatPoint
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;//This code ensure that the decimal separator is "." 

        Console.WriteLine("Enter two numbers to compare:");
        Console.Write("First number:");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Second number:");
        float secondNumber = float.Parse(Console.ReadLine());
        bool areEqual = (firstNumber == secondNumber);

        Console.WriteLine("a = {0} , b={1},  areEqual={2} ",
            firstNumber, secondNumber, areEqual);
    }
}

