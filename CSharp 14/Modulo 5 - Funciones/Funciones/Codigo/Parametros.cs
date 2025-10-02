using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class Parametros
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Una función que recibe un parámetro

            int Duplicar(int valor)
            {
                return valor * 2;
            }

            var dobleDe5 = Duplicar(5); // 10
            var dobleDe3 = Duplicar(3); // 6

            // Ejemplo 2: una función que recibe dos parámetros

            int Sumar(int sumando1, int sumando2)
            {
                return sumando1 + sumando2;
            }

            var suma = Sumar(1, 2); // 3

            // Ejemplo 3: Orden de los parámetros

            void RepetirEnConsola(string mensaje, int veces)
            {
                for (int i = 0; i < veces; i++)
                {
                    Console.WriteLine(mensaje);
                }
            }

            //RepetirEnConsola(3, "Felipe es genial"); // Error: orden incorrecto
            RepetirEnConsola(mensaje: "Felipe es genial", veces: 3);
            RepetirEnConsola(veces: 5, mensaje: "Claudia es genial");

            // Ejemplo 4: Imprimiendo matrices

            int[,] matriz = new int[2, 2];
            matriz[0, 0] = 1; // primera fila, primera columna
            matriz[0, 1] = 2; // primera fila, segunda columna
            matriz[1, 0] = 3; // segunda fila, primera columna
            matriz[1, 1] = 4; // segunda fila, segunda columna

            int[,] matriz2 = new int[,]
            {
    {5, 6},
    {7, 8 },
    {9, 10 }
            }; // Matriz de 3 filas y 2 columnas

            void ImprimirMatriz(int[,] matrizBidimensional)
            {
                for (int fila = 0; fila < matrizBidimensional.GetLength(0); fila++)
                {
                    for (int columna = 0; columna < matrizBidimensional.GetLength(1); columna++)
                    {
                        Console.Write(matrizBidimensional[fila, columna]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

            }

            ImprimirMatriz(matriz);
            Console.WriteLine("---");
            ImprimirMatriz(matriz2);
        }
    }
}
