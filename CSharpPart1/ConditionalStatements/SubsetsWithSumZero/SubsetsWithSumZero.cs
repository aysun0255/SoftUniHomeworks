using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Problem 12.* Zero Subset
 * We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume
 * that repeating the same subset several times is not a problem.
 */

class SubsetsWithSumZero
{

    static void Main()
    {
        Console.WriteLine("Enter five numbers each on new line:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());
        //int t = Math.Sign(firstNumber*secondNumber);
        // Console.WriteLine(t);

        if (firstNumber + secondNumber + thirdNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + secondNumber + "" + thirdNumber);
        }

        if (firstNumber + secondNumber + fourthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + secondNumber + "" + fourthNumber);
        }

        if (firstNumber + secondNumber + fifthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + secondNumber + "" + fifthNumber);
        }

        if (firstNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + thirdNumber + "" + fourthNumber);
        }

        if (firstNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + thirdNumber + "" + fifthNumber);
        }

        if (firstNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine(firstNumber + "" + fourthNumber + "" + fifthNumber);
        }

        if (secondNumber + thirdNumber + fourthNumber == 0)
        {
            Console.WriteLine("{0},{1},{2}", secondNumber, thirdNumber, fourthNumber);
        }

        if (secondNumber + thirdNumber + fifthNumber == 0)
        {
            Console.WriteLine(secondNumber + "" + thirdNumber + "" + fifthNumber);
        }

        if (thirdNumber + fourthNumber + fifthNumber == 0)
        {
            Console.WriteLine(thirdNumber + "" + fourthNumber + "" + fifthNumber);
        }


    }




}


