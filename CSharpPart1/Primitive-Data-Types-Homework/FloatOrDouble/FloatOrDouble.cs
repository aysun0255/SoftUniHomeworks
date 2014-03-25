using System;

/*
 * Problem 2. Float or Double?
 * Which of the following values can be assigned to a variable of type float and which to a variable of type double:
 * 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and
 * print them to ensure no precision is lost.
 */

class FloatOrDouble
{
    static void Main()
    {
        double variableDouble = 34.567839023;
        Console.WriteLine(variableDouble);

        float firstFloatVar = 12.345f;
        Console.WriteLine(firstFloatVar);

        double secondDoubleVar = 8923.1234857;
        Console.WriteLine(secondDoubleVar);

        float secondFloatVar = 3456.091f;
        Console.WriteLine(secondFloatVar);
    }
}

