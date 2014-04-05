using System;

/*
 * Problem 11.Bitwise: Extract Bit #3
 * Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits
 * are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0
 */


class ThirdBit
{
    static void Main()
    {
        uint userInput;
        bool isNumber; 
        do
        {
            Console.Write("Enter unsigned integer number:");
            isNumber = uint.TryParse(Console.ReadLine(), out userInput);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }


            
        } while (!isNumber);

        uint mask = 1;
        mask = mask << 3;
        uint thirdBit = userInput & mask;
        thirdBit = thirdBit >> 3;
        Console.WriteLine("Third bit of {0} is {1}",userInput,thirdBit);
    }
}

