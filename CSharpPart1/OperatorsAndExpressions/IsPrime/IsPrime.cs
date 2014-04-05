using System;

/*
 * Problem 8. Prime Number Check
 * Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without
 * remainder only to itself and 1).
 */

class IsPrime
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

        bool isPrime = true;
        isPrime = (userInput % 1 == 0) && (userInput % userInput == 0) && (userInput == 2 ? userInput % 2 == 0 : userInput % 2 != 0) && (userInput == 3 ? userInput % 3 == 0 : userInput % 3 != 0) && (userInput == 5 ? userInput % 5 == 0 : userInput % 5 != 0) && (userInput == 7 ? userInput % 7 == 0 : userInput % 7 != 0);

        Console.WriteLine("Is prime :{0}", isPrime);
    }
}

