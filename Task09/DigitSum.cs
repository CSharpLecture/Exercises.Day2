namespace CsharpSolutions.Exercises.Task09
{
    class DigitSum
    {
        //Can be called by DigitSum.Compute(12345, out o)
        public static int Compute(int number, out int digits)
        {
            string s = number.ToString();
            //assign the out parameter to the length of the string (# of digits)
            digits = s.Length;
            int sum = 0;

            for (int i = 0; i < digits; i++)
            {
                //The integer for a char that represents "0" is
                //different from 0. Therefore we need to subtract
                //the offset - given by the char constant '0'
                sum += s[i] - '0';
            }

            return sum;
        }
    }
}
