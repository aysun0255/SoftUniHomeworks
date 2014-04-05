using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Problem 3. Check for a Play Card
 * Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a
 * program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
 */


class PlayCard
{
    static void Main()
    {
        Console.Write("Enter card sign:");
        string sign = Console.ReadLine();
        //switch to check if given card sign is valid
        switch (sign)
        {
            case "A":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
                Console.WriteLine("Valid card sign? : yes");
                break;
            default:
                Console.WriteLine("Valid card sign? : no");
                break;
        }

    }
}

