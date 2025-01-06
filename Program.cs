using System;
using System.Numerics;
using ProjectEuler.Problems;

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
            Console.WriteLine("Largest Palindrome Product: " + SmallestMultiple.Solve());
        }
    }
}