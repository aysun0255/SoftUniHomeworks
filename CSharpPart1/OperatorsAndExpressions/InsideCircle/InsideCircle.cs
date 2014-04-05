using System;

/*
 * Problem 7. Point in a Circle
 * Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)
 */

class InsideCircle
{
    static void Main()
    {
        double x;
        double y;
        bool isNumber = false;

        do
        {
            Console.Write("Enter value for x :");
            isNumber = double.TryParse(Console.ReadLine(), out x);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);
        isNumber = false;

        do
        {
            Console.Write("Enter value for y :");
            isNumber = double.TryParse(Console.ReadLine(), out y);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        bool isInCircle = (x * x) + (y * y) <= 4;
        Console.WriteLine("Inside:{0}",isInCircle);
    }
}

