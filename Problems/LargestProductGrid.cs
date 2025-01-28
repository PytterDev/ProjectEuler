using System;
using ProjectEuler.Helpers;

namespace ProjectEuler.Problems
{
    internal class LargestProductGrid
    {
        public static int Solve()
        {
            int[,] matriz = new int[20, 20];
            int result = 0;

            string ruta = "../../../Files/matriz.txt";
            try
            {
                int j = 0;
                int number;
                List<string> listString;
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    listString = linea.Split(' ').ToList();
                    for (int i = 0; i < 20; i++)
                    {
                        number = int.Parse(listString[i]);
                        matriz[j, i] = number;
                    }
                    j++;
                }

                for (int i = 0; i < 20; i++)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        int prodLR = 0;
                        int prodUD = 0;
                        int prodDiag = 0;
                        int prodDiagInv = 0;

                        if (k < 17)
                        {
                            prodLR = matriz[i, k] * matriz[i, k + 1] * matriz[i, k + 2] * matriz[i, k + 3];
                        }
                        if (i < 17)
                        {
                            prodUD = matriz[i, k] * matriz[i + 1, k] * matriz[i + 2, k] * matriz[i + 3, k];
                        }
                        if ((k < 17) && (i < 17))
                        {
                            prodDiag = matriz[i, k] * matriz[i + 1, k + 1] * matriz[i + 2, k + 2] * matriz[i + 3, k + 3];
                        }
                        if ((k < 17) && (i > 2))
                        {
                            prodDiagInv = matriz[i, k] * matriz[i - 1, k + 1] * matriz[i - 2, k + 2] * matriz[i - 3, k + 3];
                        }

                        result = MathHelper.biggestNumber(result, prodLR);
                        result = MathHelper.biggestNumber(result, prodUD);
                        result = MathHelper.biggestNumber(result, prodDiag);
                        result = MathHelper.biggestNumber(result, prodDiagInv);
                    }
                }

                /*
                string line = "";
                for (int i = 0;i < 20; i++)
                {
                    for (int k = 0; k < 20; k++)
                    {
                        line = line + " " + matriz[i, k];
                    }
                    Console.WriteLine(line);
                    line = "";
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return result;
        }
    }
}
