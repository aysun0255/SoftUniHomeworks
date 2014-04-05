using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SumFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers(seperated by space):");
        string[] input = Console.ReadLine().Split(' ');
        int sum = 0;
        foreach (var num in input)
        {
            sum += int.Parse(num);
        }

        Console.WriteLine("Sum of entered numbers is:{0}",sum);
    }
}

