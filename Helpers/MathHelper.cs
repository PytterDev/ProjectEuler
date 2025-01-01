using System;

namespace ProjectEulerSolution.Helpers
{
    public class MathHelper
    {
        public static int Multiples(int limitNumber, int multiple)
        {
            List<int> multiplesThree = new List<int>();

            for (int i = 1; i < limitNumber; i++)
            {
                if (i % multiple == 0) multiplesThree.Add(i);
            }

            return multiplesThree.Count;
        }


        public static int SumList(List<int> listNumbers)
        {
            int sumNumbers = 0;

            foreach (int number in listNumbers)
            {
                sumNumbers += number;
            }

            return sumNumbers;
        }
    }
}

