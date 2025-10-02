using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class EjecucionDiferida
    {
        public void CodigoDelCurso()
        {
            int[] numeros = Enumerable.Range(1, 5).ToArray();

            // Paso 1: Ejecución diferida
            var numerosPares = numeros.Where(n =>
            {
                Console.WriteLine($"Evaluando si {n} es par");
                return n % 2 == 0;

            });

            Console.WriteLine();

            // El query anterior se va a ejecutar cuando hagamos el foreach.
            foreach (var numero in numerosPares)
            {
                Console.WriteLine($"El número {numero} es par");
            }
        }
    }
}
