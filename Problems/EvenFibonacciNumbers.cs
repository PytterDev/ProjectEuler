using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class EvenFibonacciNumbers
    {
        public static int Solve(int limitNumber)
        {
            bool model;
            int firstNumber;
            int secondNumber = 2;
            int addingNumber = 3;
            List<int> fibonacciNumbers = [2];
            List<int> listSum = [];

            while (addingNumber < limitNumber)
            {
                model = MathHelper.Model(addingNumber, 2);

                if (model)
                {
                    fibonacciNumbers.Add(addingNumber);
                }    

                firstNumber = secondNumber;
                secondNumber = addingNumber;
                listSum.Add(firstNumber);
                listSum.Add(secondNumber);
                addingNumber = MathHelper.SumList(listSum);
                listSum.Clear();
            }

            int result = MathHelper.SumList(fibonacciNumbers);

            return result;
        }
    }
}
