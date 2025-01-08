using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class FirstPrimeNumber
    {
        public static long Solve(int limitNumber)
        {
            long result = 0;
            int count = 0;
            long number = 2;

            while (true)
            {
                if (MathHelper.IsPrime(number))
                {
                    result = number;
                    count++;
                    //Console.WriteLine(number + " - " + count);
                }

                if (count == limitNumber) break;

                number++;
            }

            return result;
        }
    }
}
