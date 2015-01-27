using System;

namespace CsharpSolutions.Exercises.Task08
{
    class Integrator
    {
        //Call it like Integrator.Integrate(0, 1, 1000, Math.Sin)
        public static double Integrate(double a, double b, int N, Func<double, double> f)
        {
            //Compute Delta x by dividing the whole x range by the number of rectangles
            double width = (b - a) / N;
            //store the sum
            double sum = 0.0;
            //start at x = a
            double x = a;

            for (int i = 0; i < N; i++)
            {
                //Add it to the global sum
                sum += f(x);
                //Increase x, i.e. x_i = x_[i-1]+Delta x
                x += width;
            }

            //In the end multiply with Delta x
            return sum * width;
        }
    }
}
