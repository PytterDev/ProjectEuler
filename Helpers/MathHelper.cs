using System;

namespace ProjectEuler.Helpers
{
    public class MathHelper
    {
        public static List<int> Multiples(int limitNumber, List<int> multiples)
        {
            List<int> result = [];

            for (int i = 1; i < limitNumber; i++)
            {
                bool isMultiple = IsMultiple(multiples, i);

                if (isMultiple) result.Add(i);
            }

            return result;
        }


        public static bool IsMultiple(List<int> multiples, int number)
        {
            var result = false;

            foreach (int multiple in multiples)
            {
                if (number % multiple == 0) result = true;
            }
            
            return result;
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


        public static bool Model(long number, long model)
        {
            long preResult = number % model;
            bool result = preResult == 0;

            return result;
        }
    }
}

