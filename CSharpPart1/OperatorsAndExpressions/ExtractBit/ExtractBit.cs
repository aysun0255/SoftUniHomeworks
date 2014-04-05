using System;

/*
 * Problem 12.Extract Bit from Integer
 * Write an expression that extracts from given integer n the value of given bit at index p.
 */

class ExtractBit
{
    static void Main()
    {
        int n;
        bool isNumber;
        do
        {
            Console.Write("Enter int numberto check:");
            isNumber = int.TryParse(Console.ReadLine(), out n);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        } while (!isNumber);

        int p;
        do
        {
            Console.Write("Enter position to check:");
            isNumber = int.TryParse(Console.ReadLine(), out p);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        } while (!isNumber);

        int mask = 1 << p;
        int checkedBit = mask & n;
        checkedBit = checkedBit >> p;
        Console.WriteLine("The bit at position {0} of {1} is {2}",p,n,checkedBit);
    }
}

