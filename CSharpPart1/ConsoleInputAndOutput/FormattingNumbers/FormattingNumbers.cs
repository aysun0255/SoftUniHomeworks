using System;

/*
 * Problem 5. Formatting Numbers
 * Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints
 * them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should
 * be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes,
 * then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be
 * printed with 3 digits after the decimal point, left aligned.
 */

class FormattingNumbers
{
    static void Main()
    {
        //read three numbers 
        int a;
        bool isNumber;
        do
        {
            Console.Write("a=");
            isNumber = int.TryParse(Console.ReadLine(), out a);

            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");

            }


        } while (!isNumber);

        double b;
        do
        {
            Console.Write("b=");
            isNumber = double.TryParse(Console.ReadLine(), out b);

            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");

            }


        } while (!isNumber);

        double c;
        do
        {
            Console.Write("c=");
            isNumber = double.TryParse(Console.ReadLine(), out c);

            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");

            }


        } while (!isNumber);

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|",a,Convert.ToString(a,2),b,c);
    }
}

