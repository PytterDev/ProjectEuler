using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class SmallestMultiple
    {
        public static int Solve()
        {
            int result = 0;
            int initNumber = 2520;
            int count;

            while (true)
            {
                count = 0;
                while (count <= 20)
                {
                    count++;
                    if (!MathHelper.IsModel(initNumber, count))
                    {
                        break;
                    }
                }

                count = count - 1;

                if (count == 20)
                {
                    result = initNumber;
                    break;
                }

                initNumber++;
            }

            return result;
        }
    }
}
