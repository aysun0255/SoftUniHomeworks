using System;

/*
 * Problem 6. Four-Digit Number
 *   Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 *   Calculates the sum of the digits (in our example 2+0+1+1 = 4).
 *   Prints on the console the number in reversed order: dcba (in our example 1102).
 *   Puts the last digit in the first position: dabc (in our example 1201).
 *    Exchanges the second and the third digits: acbd (in our example 2101).
 *   The number has always exactly 4 digits and cannot start with 0. 
 */

class FourDigitNumber
{
    static void Main()
    {
        int userInput;
        bool isNumber;

        do
        {
            Console.Write("Enter four digit number:");

            isNumber = int.TryParse(Console.ReadLine(), out userInput) && userInput.ToString().Length == 4;
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }

        }
        while (!isNumber);

        string enteredNumber = userInput.ToString();
        int[] numbers = {(int)Char.GetNumericValue(enteredNumber[0]),(int)Char.GetNumericValue(enteredNumber[1]),
                        (int)Char.GetNumericValue(enteredNumber[2]),(int)Char.GetNumericValue(enteredNumber[3])};

        Console.WriteLine("Sum of digits:{0}",numbers[0] + numbers[1] + numbers[2] + numbers[3]);
        Console.WriteLine("Reversed:" + numbers[3] + numbers[2] + numbers[1] + numbers[0]);
        Console.WriteLine("Last digit in front:" + numbers[3] + numbers[0] + numbers[1] + numbers[2]);
        Console.WriteLine("Second and third digits exchanged:" + numbers[0] + numbers[2] + numbers[1] + numbers[3]);
    }
}

