using System;

/*
 * Problem 10.Point Inside a Circle & Outside of a Rectangle
 * Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle
 * R(top=1, left=-1, width=6, height=2)
 */

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        double x;
        bool isNumber;
        do
        {
            Console.WriteLine("Enter value for x:");
            isNumber = double.TryParse(Console.ReadLine(), out x);

            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid umber.");
            }

        } while (!isNumber);

        double y;
        do
        {
            Console.WriteLine("Enter value for y:");
            isNumber = double.TryParse(Console.ReadLine(), out y);

            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid umber.");
            }

        } while (!isNumber);

        bool isInCircle = Math.Pow((x - 1),2) + Math.Pow((y - 1),2) <= Math.Pow(1.5, 2);//(x - center_x)^2 + (y - center_y)^2 < radius^2
        bool outsideRectangle = ((y > 1 || y < -1) && (x >= -1 && x <= 5)) || (x < -1 || x > 5);
        string result = isInCircle && outsideRectangle ? "yes" : "no";
        Console.WriteLine("Inside K and outside of R:{0}", result);
    }
}

