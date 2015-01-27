using System;

namespace CsharpSolutions.Exercises.Task07
{
    class NumberGuesser
    {
        //This can be called like NumberGuesser.Game()
        public static void Game()
        {
            //Generate an instance of the Random numer generator class
            Random r = new Random();

            //Some output
            Console.WriteLine("What is the lowest number?");
            int lower;

            //If this is an invalid input, return
            if (!int.TryParse(Console.ReadLine(), out lower))
            {
                Console.WriteLine("The lower number is invalid.");
                return;
            }

            Console.WriteLine("What is the highest number?");
            int upper;

            //If this is an invalid input, return
            if (!int.TryParse(Console.ReadLine(), out upper))
            {
                Console.WriteLine("The upper number is invalid.");
                return;
            }

            //Generate the real value (random number)
            int num = r.Next(Math.Min(lower, upper), Math.Max(upper, lower) + 1);
            //the number of tries is given by the # of values / 3
            int tries = Math.Max((upper - lower) / 3, 1);

            //The number of tries is positive
            while (tries > 0)
            {
                Console.WriteLine("Still {0} tries available. What is your guess?", tries);
                int guess;

                //Try to parse the value
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Not a valid number.");
                    continue;
                }

                tries--;

                if (guess == num)
                {
                    Console.WriteLine("YOU JUST GOT IT ... RIGHT!!");
                    break;
                }
                else if (guess > num)
                {
                    Console.WriteLine("Just a little bit lower...");
                }
                else
                {
                    Console.WriteLine("Higher baby!");
                }
            }
        }
    }
}
