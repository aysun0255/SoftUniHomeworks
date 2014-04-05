using System;


/*
 * Problem 4. Rectangles
 * Write an expression that calculates rectangle’s perimeter and area by given width and height. E
 */
class Rectangles
{
    static void Main()
    {
        double width;
        bool isNumber;

        do
        {
            Console.Write("Rectange width:");
            isNumber = double.TryParse(Console.ReadLine(), out width);

            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        double height;
        isNumber = false;

        do
        {
            Console.Write("Rectangle height:");
            isNumber = double.TryParse(Console.ReadLine(), out height);

            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine("Rectangle area:{0}.Rectangle perimeter:{1}",area,perimeter);
    }
}

