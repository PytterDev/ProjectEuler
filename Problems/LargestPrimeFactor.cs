using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class LargestPrimeFactor
    {
        public static long Solve(long limitNumber)
        {
            long maxNumber = (long)Math.Floor(Math.Pow(limitNumber, 0.5));

            for (long number = maxNumber; number >= 2; number--)
            {
                if (MathHelper.Model(limitNumber, number) && MathHelper.Prime(number)) return number;
            }

            return 0;
        }
    }
}
