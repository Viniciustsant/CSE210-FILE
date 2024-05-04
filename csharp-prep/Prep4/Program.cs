using System;
using System.Formats.Asn1;
using System.Text.Json.Serialization;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int answer = -1;
        List <int> numbers = new List<int>();


        while (answer != 0)
        {
            Console.WriteLine("Enter a Number (enter 0 to stop) ");

            string answerS = Console.ReadLine();
            answer = int.Parse(answerS);

            if (answer != 0)
                numbers.Add(answer);
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}