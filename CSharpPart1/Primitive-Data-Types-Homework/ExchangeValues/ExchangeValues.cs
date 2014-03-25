using System;

/*
 * Problem 9. Exchange Variable Values
 * Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the
 * variable values before and after the exchange
 */

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a={0}", a);
        Console.WriteLine("b={0}", b);
    }
}
