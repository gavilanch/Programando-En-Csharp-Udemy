using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones.Codigo
{
    internal class UsandoYield
    {
        public void CodigoDelCurso()
        {
            var numeros = new List<int> { 1, 2, 3 };

            var numerosCasteadoAEnumerable = numeros.AsEnumerable();

            var enumerableDeNumeros = Primeros3Numeros();

            var primerNumero = enumerableDeNumeros.First();

            var primerosDosElementos = enumerableDeNumeros.Take(2);

            foreach (var valor in primerosDosElementos)
            {
                Console.WriteLine(valor);
            }

            var todosLosNumeros = enumerableDeNumeros.ToList();

            Console.WriteLine();

            IEnumerable<int> Primeros3Numeros()
            {
                yield return 1;
                yield return 2;
                yield return 3;
            }
        }
    }
}
