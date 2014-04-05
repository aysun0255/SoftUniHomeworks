using System;

/*
 * Problem 3. Divide by 7 and 5
 * Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the
 * same time
 */

class DividedBy
{
    static void Main()
    {
        int userInput;
        bool isNumber;

        do
        {
            Console.Write("Enter number to check:");
            isNumber = int.TryParse(Console.ReadLine(), out userInput);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }

        }
        while(!isNumber);

        bool isDivided = (userInput % 5 == 0) && (userInput % 7 == 0);
        if (isDivided)
        {
            Console.WriteLine("Entered number can be divided by 7 and 5.");
        }
        else
        {
            Console.WriteLine("Entered number can not be divided by 7 and 5.");
        }
    }
}
