using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class SumSquareDifference
    {
        public static double Solve(int limitNumber)
        {
            double result;
            var resultSquares = 0.0;
            double sumSquare = 0.0;
            var accumNumbers = 0;

            for (int number = 1; number <= limitNumber; number++)
            {
                resultSquares = resultSquares + Math.Pow(number, 2);
                accumNumbers = accumNumbers + number;

                if (number == limitNumber)
                {
                    sumSquare = Math.Pow(accumNumbers, 2);
                }
            }
            Console.WriteLine(sumSquare + " - " + resultSquares);

            result = sumSquare - resultSquares;

            return result;
        }
    }
}
