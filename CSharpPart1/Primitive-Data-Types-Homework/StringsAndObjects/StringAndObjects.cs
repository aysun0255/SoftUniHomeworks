﻿using System;

/*
 *Problem 6. Strings and Objects
 * Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it
 * with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable
 * and initialize it with the value of the object variable (you should perform type casting).
 */

class StringAndObjects
{
    static void Main()
    {
        string printHello = "Hello";
        string printWorld = "World";
        object concatenation = printHello + " " + printWorld;
        string newString = (string)concatenation;

        Console.WriteLine(concatenation);
        Console.WriteLine(newString);
    }
}
