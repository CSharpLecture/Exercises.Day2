using System;

namespace CsharpSolutions.Exercises.Task06
{
    class MySwap
    {
        //A simple test for our swap method
        public static void TestSwap()
        {
            //Some initial values
            int a = 0;
            int b = 1;
            //Call the swap method
            Swap(ref a, ref b);

            //If the values haven't been swapped, throw this exception
            if (a != 1 || b != 0)
                throw new Exception("Does not work!!!");

            //Alright!
            Console.WriteLine("Works!");
        }

        //This is my own swap method
        public static void Swap(ref int a, ref int b)
        {
            //Swap by using a temporary variable
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
