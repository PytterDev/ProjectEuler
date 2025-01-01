using System;

namespace ProjectEulerSolutions
{
    public class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project Euler Solutions");

            // Ejecutar soluciones a problemas
            Console.WriteLine("Multiples of 3 or 5: " + Problem1.Solve());
            Console.WriteLine("Problema 2: " + Problem2.Solve());
        }
    }
}