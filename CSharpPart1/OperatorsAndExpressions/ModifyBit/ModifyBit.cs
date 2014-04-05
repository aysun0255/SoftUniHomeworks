using System;

/*
 * Problem 14.Modify a Bit at Given Position
 * We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few
 * lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while
 * preserving all other bits in n.
 */

class ModifyBit
{
    static void Main()
    {
        int n;
        bool isNumber;
        do
        {
            Console.WriteLine("Enter number to modify its bit:");
            isNumber = int.TryParse(Console.ReadLine(), out n);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }

        } while (!isNumber);

        int p;
        do
        {
            Console.WriteLine("Enter position to modify:");
            isNumber = int.TryParse(Console.ReadLine(), out p);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }

        } while (!isNumber);

        int v;
        do
        {
            Console.WriteLine("Enter value to set at given position (0 or 1):");
            isNumber = int.TryParse(Console.ReadLine(), out v) && (v == 0 || v == 1);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }

        } while (!isNumber);

        int mask = 1 << p;
        mask = (v == 0) ? ~mask : mask;
        int result = (v == 0) ? n & mask : n | mask;
        Console.WriteLine("Entered number:{0}", n);
        Console.WriteLine("Bit at position {0} is changed with {1}", p, v);
        Console.WriteLine("Result is:{0}", result);
    }
}

