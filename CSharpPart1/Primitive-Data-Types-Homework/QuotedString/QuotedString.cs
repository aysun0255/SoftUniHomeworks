﻿using System;

/*
 * Problem 7. Quotes in Strings
 * Declare two string variables and assign them with following value:
 * The "use" of quotations causes difficulties.
 * Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their
 * value was correctly defined
 */

class QuotedString
{
    static void Main()
    {
        string stringOne = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(stringOne);

        string stringTwo = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(stringTwo);
    }
}
