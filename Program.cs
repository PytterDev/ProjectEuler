using System;
using System.Collections.Generic;
using System.Numerics;
using ProjectEuler.Problems;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectEuler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler Solutions");

            // Ejecutar soluciones a problemas
            //Console.WriteLine("Multiples of 3 or 5: " + MultiplesThreeFive.Solve(1000, [3, 5]));
            //Console.WriteLine("Even Fibonacci Numbers: " + EvenFibonacciNumbers.Solve(4000000));
            //Console.WriteLine("Largest Prime Factor: " + LargestPrimeFactor.Solve(600851475143));
            //Console.WriteLine("Largest Palindrome Product: " + LargestPalindromeProduct.Solve());
            //Console.WriteLine("Smallest Multiple: " + SmallestMultiple.Solve());
            //Console.WriteLine("Sum Square Difference: " + SumSquareDifference.Solve(100));
            //Console.WriteLine("First Prime Number: " + FirstPrimeNumber.Solve(10001));
            //Console.WriteLine("Largest Product in a Series: " + LargestProductSeries.Solve(13));
            //Console.WriteLine("Special Pythagorean Triplet: " + SpecialPythagoreanTriplet.Solve(1000));
            Console.WriteLine("Summation of Primes: " + SummationPrimes.Solve(10));
        }
    }
}