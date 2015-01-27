using System;

namespace CsharpSolutions.Exercises.Task10
{
    class ConsoleInteraction
    {
        //Field to store the message
        string message;

        // Standard constructor
        public ConsoleInteraction()
            : this("Please enter a valid number")
        {
        }

        // Constructor that sets the message to a custom value
        public ConsoleInteraction(string message)
        {
            this.message = message;
            ErrorMessage = "Invalid number! Try again ...";
        }

        // A property that stores a custom error message
        public string ErrorMessage
        {
            get;
            set;
        }

        //Parses an integer input
        public int ParseInt()
        {
            // As long as no integer has been inserted
            while (true)
            {
                //Check that
                int tmp;
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out tmp))
                    return tmp;

                //Output an error !!
                Console.WriteLine(ErrorMessage);
            }
        }

        //Parses a double input
        public double ParseDouble()
        {
            // As long as no double has been inserted
            while (true)
            {
                //Check that
                double tmp;
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out tmp))
                    return tmp;

                //Output an error !!
                Console.WriteLine(ErrorMessage);
            }
        }
    }
}
