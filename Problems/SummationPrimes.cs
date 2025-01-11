using System;
using ProjectEuler.Helpers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectEuler.Problems
{
    internal class SummationPrimes
    {
        public static long Solve(int limitNumber)
        {
            long result = 0;
            Parallel.For(2, limitNumber, number =>
            {
                if (MathHelper.IsPrime(number))
                {
                    result += number;
                }
            });

            return result;
        }
    }
}
