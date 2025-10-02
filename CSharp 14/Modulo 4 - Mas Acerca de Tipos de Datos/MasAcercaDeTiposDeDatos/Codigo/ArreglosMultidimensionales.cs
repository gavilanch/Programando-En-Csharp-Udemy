using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class ArreglosMultidimensionales
    {
        public void CodigoDelCurso()
        {
            int[,] matriz = new int[2, 2];

            //Console.WriteLine(matriz.Rank); // 2

            matriz[0, 0] = 1; // primera fila, primera columna
            matriz[0, 1] = 2; // primera fila, segunda columna
            matriz[1, 0] = 3; // segunda fila, primera columna
            matriz[1, 1] = 4; // segunda fila, segunda columna

            var elemento01 = matriz[0, 1]; // 2

            int[,] matriz2 = new int[,]
            {
                {5,6 }, // primera fila
                {7, -5 }, // segunda fila
                {8, 9 } // tercera fila
            };

            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    Console.Write($"{matriz2[fila, columna]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
