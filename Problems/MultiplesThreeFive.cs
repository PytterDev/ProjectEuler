using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class MultiplesThreeFive
    {
        public static int Solve(int limitNumber, List<int> factors)
        {
            List<int> multiples = MathHelper.Multiples(limitNumber, factors);

            int result = MathHelper.SumList(multiples);

            return result;
        }
    }
}