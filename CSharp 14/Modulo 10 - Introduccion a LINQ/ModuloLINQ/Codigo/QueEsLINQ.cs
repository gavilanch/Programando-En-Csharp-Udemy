using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class QueEsLINQ
    {
        public void CodigoDelCurso()
        {
            int[] numeros = Enumerable.Range(1, 5).ToArray();

            // Esto es LINQ (sintaxis de métodos)
            var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

            // Forma 2: Sintaxis de queries
            var numerosPares2 = (from n in numeros
                                 where n % 2 == 0
                                 select n).ToList();
        }
    }
}
