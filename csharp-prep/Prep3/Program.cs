using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int guess = -1;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);



        while (guess != number)
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());


                if (number == guess)
                    {
                        Console.WriteLine("You guessed it!");
                    }

                else if (guess > number)
                    {
                        Console.WriteLine("Lower");
                    }

                else if (guess < number )
                    {
                        Console.WriteLine("Higher");
                    }
            }
    }
}