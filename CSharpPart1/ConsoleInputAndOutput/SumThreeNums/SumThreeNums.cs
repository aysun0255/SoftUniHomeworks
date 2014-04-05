using System;

/*
 * Problem 1. Sum of 3 Numbers
 * Write a program that reads 3 real numbers from the console and prints their sum.
 */
 
class SumThreeNums
{
    static void Main()
    {
        Console.WriteLine("Enter 3 nums to sum(each on new line):");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int sum = first + second + third;
        Console.WriteLine("Sum of enterd numbers is:{0}",sum);
    }
}

