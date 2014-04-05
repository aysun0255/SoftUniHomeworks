using System;

/*
 * Problem 9. Trapezoids
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter value for a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for height:");
        double height = double.Parse(Console.ReadLine());

        double area = 0.5 * (a + b) * height;
        Console.WriteLine("Trapezoid area is:{0}",area);


    }
}

