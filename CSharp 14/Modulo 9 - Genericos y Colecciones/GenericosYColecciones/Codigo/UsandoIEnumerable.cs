using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones.Codigo
{
    internal class UsandoIEnumerable
    {
        public void CodigoDelCurso()
        {
            var numeros = new List<int> { 1, 2, 3 };

            ImprimirEnConsola(numeros);

            string[] nombres = { "Felipe", "Claudia" };

            Console.WriteLine();

            ImprimirEnConsola(nombres);

            void ImprimirEnConsola<T>(IEnumerable<T> valores)
            {
                foreach (var valor in valores)
                {
                    Console.WriteLine(valor);
                }
            }
        }
    }
}
