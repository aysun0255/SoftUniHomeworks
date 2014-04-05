using System;

/*
 * Problem 1. Exchange If Greater
 * Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater
 * than the second one. As a result print the values a and b, separated by a space. 
 */

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b:");
        int b = int.Parse(Console.ReadLine());
        
        //if a is greater than b exchange their values
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("result:{0} {1}",a,b);
    }
}

