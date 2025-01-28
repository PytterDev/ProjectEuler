using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class HighlyDivisibleTriangularNumber
    {
        public static int Solve()
        {
            var count = 0;
            var sum = 0;
            var fact = 0;
            var isModel = false;
            var countModel = 0;

            while (true)
            {
                count++;
                sum += count;
                countModel = 0;

                for (int i = 1; i <= sum; i++)
                {
                    isModel = MathHelper.IsModel(sum, i);
                    if (isModel) countModel++;
                }
                if (countModel > 500) break;
            }

            return sum;
        }
    }
}
