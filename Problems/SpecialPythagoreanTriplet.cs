using System;

namespace ProjectEuler.Problems
{
    internal class SpecialPythagoreanTriplet
    {
        public static double Solve(int limitNumber)
        {
            double a = 2;
            double b;
            double c;
            double result;
            bool listo = false;

            while (true)
            {
                b = a + 1;
                while (true)
                {
                    c = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
                    if (a + b + c == limitNumber)
                    {
                        listo = true;
                        break;
                    }
                    if (a + b + c > limitNumber) break;
                    b++;
                }
                if (listo) break;
                a++;
            }

            result = a * b * c;
            return result;
        }
    }
}
