using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 9. Play with Int, Double and String
 * Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or
 * double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the
 * result at the console. Use switch statement.
 */



class IntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please choose type(1-int,2-double,3-string):");
        int userInput = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                Console.Write("Please enter int:");
                int intNum = int.Parse(Console.ReadLine());
                intNum++;
                Console.WriteLine(intNum);
                break;
            case 2:
                Console.Write("Please enter double:");
                double doubleNum = double.Parse(Console.ReadLine());
                doubleNum++;
                Console.WriteLine(doubleNum);
                break;
            case 3:
                Console.Write("Please enter string:");
                string userString = Console.ReadLine();
                userString = userString + "*";
                Console.WriteLine(userString);
                break;
            default:
                Console.WriteLine("Invalid choose!Please enter valid option(from 1 to 3).");
                Main();
                break;
        }
    }
}

