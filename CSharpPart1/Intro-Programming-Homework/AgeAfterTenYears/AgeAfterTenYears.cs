using System;

/*
 * Problem 15
 * Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years. 
 */

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday:");
        Console.Write("Day:");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Month:");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Year:");
        int year = int.Parse(Console.ReadLine());
        DateTime birthday = new DateTime(year, month, day);
        int currentYear = DateTime.Today.Year;
        int age = currentYear - birthday.Year;
        Console.WriteLine("Your current age is:{0}",age);
        int ageAfterTenYears = age + 10;
        Console.WriteLine("After ten years you will be {0} years old.",ageAfterTenYears);
    }
}

