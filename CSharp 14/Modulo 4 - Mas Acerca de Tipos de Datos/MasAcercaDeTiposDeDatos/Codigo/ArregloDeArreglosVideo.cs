using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class ArregloDeArreglosVideo
    {
        public void CodigoDelCurso()
        {
            int[][] arregloDeArreglos = {
                                            new int[]{1,2},
                                            new int[]{3,4,5},
                                            new int[]{6},
                                            new int[]{7,8}
                                        };

            var segundoElemento = arregloDeArreglos[1]; // [3,4,5]

            foreach (var valor in segundoElemento)
            {
                Console.Write($"{valor} ");
            }

            Console.WriteLine();

            // Cambiamos el valor del 4 elemento del arreglo
            arregloDeArreglos[3] = new int[] { 9, 10, 11 };

            var tercerElemento = arregloDeArreglos[3];

            foreach (var valor in tercerElemento)
            {
                Console.Write($"{valor} ");
            }

            Console.WriteLine();

            for (int fila = 0; fila < arregloDeArreglos.Length; fila++)
            {
                var arreglo = arregloDeArreglos[fila];
                for (int columna = 0; columna < arreglo.Length; columna++)
                {
                    Console.Write($"{arreglo[columna]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
