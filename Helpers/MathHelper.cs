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

        public static bool IsModel(long number, long model)
        {
            long preResult = number % model;
            bool result = preResult == 0;

            return result;
        }

        public static List<long> Primes(long limitNumber)
        {
            List<long> result = [];
            long upNumber;
            int count;
            bool isPrime;

            for (long number = 2; number <= limitNumber; number++)
            {
                isPrime = IsPrime(number);

                if (isPrime) result.Add(number);
            }

            return result;
        }

        public static bool IsPrime(long number)
        {
            long upNumber = 2;
            int count = 0;
            bool isPrime = true;

            while (upNumber <= number)
            {
                if (IsModel(number, upNumber)) count++;

                if (count > 1)
                {
                    isPrime = false;
                    break;
                }

                upNumber++;
            }

            return isPrime;
        }

        public static bool IsPalindrome(int number)
        {
            string sNumber = number.ToString();
            int lenNumber = sNumber.Length;
            int halfLenNumber = lenNumber / 2;
            int startNumber = 0;
            int endNumber = lenNumber - 1;
            char firstCharacter;
            char lastCharacter;
            bool isPalindrome = true;

            while (halfLenNumber > 0)
            {
                firstCharacter = sNumber[startNumber];
                lastCharacter = sNumber[endNumber];

                if (firstCharacter != lastCharacter) isPalindrome = false;

                startNumber++;
                endNumber--;
                halfLenNumber--;
            }

            return isPalindrome;
        }
    }
}

