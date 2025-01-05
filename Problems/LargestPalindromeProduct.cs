using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class LargestPalindromeProduct
    {
        public static int Solve()
        {
            int secondNumber;
            int preResult;
            int result = 0;

            for (int number = 999; number > 0; number--)
            {
                secondNumber = number;
                while (secondNumber > 0)
                {
                    preResult = secondNumber * number;
                    if (MathHelper.IsPalindrome(preResult))
                    {
                        if (preResult > result) result = preResult;
                    }
                    secondNumber--;
                }
            }

            return result;
        }
    }
}
