using System;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler Solutions");

            // Ejecutar soluciones a problemas
            Console.WriteLine("Multiples of 3 or 5: " + MultiplesThreeFive.Solve(1000, [3, 5]));
        }
    }
}