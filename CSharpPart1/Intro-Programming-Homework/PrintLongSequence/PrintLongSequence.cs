using System;


/* Problem 16
 * Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).
 */

class PrintLongSequence
{
    static void Main()
    {
        int l = 2;
        int n = 5;
        for (int i = 0; i < 500; i++)
        {
            Console.WriteLine(l);
            Console.WriteLine(l - n);
            l += 2;
            n += 4;
        }
    }
}

