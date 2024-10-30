using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (usernumber != 0)
        {    
            string mynumber = Console.ReadLine();
            usernumber = int.Parse(mynumber);

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

       float average = ((float)sum) / numbers.Count;
       Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number> max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}