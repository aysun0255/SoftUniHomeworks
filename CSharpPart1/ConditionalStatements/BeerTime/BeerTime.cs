using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 10.* Beer Time
 * A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an
 * hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer
 * time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to
 * learn how to parse dates and times.
 */

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time(hh:mm tt):");
        string userInput = Console.ReadLine();
        DateTime inputTime;
        bool isValidTime = DateTime.TryParse(userInput, out inputTime);
        DateTime beerTimeStart = DateTime.Parse("1:00 PM", CultureInfo.InvariantCulture);
        DateTime beerTimeEnd = DateTime.Parse("3:00 AM", CultureInfo.InvariantCulture);
        beerTimeEnd = beerTimeEnd.AddDays(1);


        if (isValidTime)
        {


            if (inputTime >= beerTimeStart && inputTime < beerTimeEnd)
            {

                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time.Please enter valid time in given format.");
            Main();
        }
    }

}

