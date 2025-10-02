using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrencia
{
    internal class MatrizUtilidades
    {
        public static void MultiplicarMatricesSecuencial(double[,] matA,
            double[,] matB, double[,] resultado)
        {
            int matAColumnas = matA.GetLength(1);
            int matBColumnas = matB.GetLength(1);
            int matAFilas = matA.GetLength(0);

            for (int i = 0; i < matAFilas; i++)
            {
                for (int j = 0; j < matBColumnas; j++)
                {
                    double temp = 0;

                    for (int k = 0; k < matAColumnas; k++)
                    {
                        temp += matA[i, k] * matB[k, j];
                    }

                    resultado[i, j] = temp;
                }
            }
        }

        public static void MultiplicarMatricesParalelo(double[,] matA,
            double[,] matB, double[,] resultado)
        {
            int matAColumnas = matA.GetLength(1);
            int matBColumnas = matB.GetLength(1);
            int matAFilas = matA.GetLength(0);

            Parallel.For(0, matAFilas, i =>
            {
                for (int j = 0; j < matBColumnas; j++)
                {
                    double temp = 0;

                    for (int k = 0; k < matAColumnas; k++)
                    {
                        temp += matA[i, k] * matB[k, j];
                    }

                    resultado[i, j] = temp;
                }
            });
        }

        public static double[,] InicializarMatriz(int filas, int columnas)
        {
            double[,] matriz = new double[filas, columnas];

            Random r = new Random();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = r.Next(100);
                }
            }

            return matriz;
        }
    }
}
