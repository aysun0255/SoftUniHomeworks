using System;

/*
 * Problem 13.Check a Bit at Given Position
 * Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given
 * integer number n has value of 1.
 */

class CheckBitAtGivenPosition
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
        bool checkedBitIs1 = checkedBit == 1;
        Console.WriteLine("The bit at position {0} of {1} is 1:{2}", p, n, checkedBitIs1);
    }
}
