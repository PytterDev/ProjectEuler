using System;
using System.Numerics;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class LargeSum
    {
        public static string Solve()
        {
            BigInteger number;
            BigInteger sum = 0;
            string ruta = "../../../Files/lista.txt";
            string result = "";

            try
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    number = BigInteger.Parse(linea);
                    sum += number;
                }

                result = sum.ToString().Substring(0, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return result;
        }
    }
}
