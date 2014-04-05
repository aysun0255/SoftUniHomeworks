using System;

/*
 * Problem 4. Rectangles
 * Write an expression that calculates rectangle’s perimeter and area by given width and height. 
 */


class ThirdDigit
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
        while (!isNumber);

        int thirdDigit = userInput / 100;
        thirdDigit = thirdDigit % 10;

        bool thirdDigit7 = thirdDigit == 7;

        Console.WriteLine("Third digit is 7? : {0}",thirdDigit7);
    }
}

