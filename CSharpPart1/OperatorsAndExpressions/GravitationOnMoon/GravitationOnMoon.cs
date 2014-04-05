using System;

/*
 * Problem 2. Gravitation on the Moon
 * The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the
 * weight of a man on the moon by a given weight on the Earth
 */

class GravitationOnMoon
{
    static void Main()
    {
        double userInput;
        bool isNumber;

        do
        {
            Console.Write("Enter weight on earth:");
            isNumber = double.TryParse(Console.ReadLine(), out userInput);

            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        double weightOnMoon = userInput * 0.17;
        Console.WriteLine("Weight on the Moon is:{0}", weightOnMoon);
    }
}

