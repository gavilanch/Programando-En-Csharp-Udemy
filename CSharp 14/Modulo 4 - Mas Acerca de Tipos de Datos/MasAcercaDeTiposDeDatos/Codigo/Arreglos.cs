using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class Arreglos
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Arreglo de char's

            char[]? vocales = new char[5];
            //vocales = null; // Los arreglos son tipo de referencia

            vocales[0] = 'a'; // Primer elemento
            vocales[1] = 'e'; // Segundo elemento
            vocales[2] = 'i';
            vocales[3] = 'o';
            vocales[4] = 'u';

            var segundaVocal = vocales[1];

            Console.WriteLine(segundaVocal); // e

            //var unaVocalMagica = vocales[5]; // no hay sexto elemento

            foreach (var vocal in vocales)
            {
                Console.WriteLine(vocal);
            }

            // Ejemplo 2: Arreglo de enteros

            var primeros6Numeros = new int[] { 1, 2, 3, 4, 5, 6 };

            foreach (var numero in primeros6Numeros)
            {
                Console.Write($"{numero} ");
            }
        }
    }
}
