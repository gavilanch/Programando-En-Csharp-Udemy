using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class BucleDoWhile
    {
        public void CodigoDelCurso()
        {
            int contador = 1;

            // El bloque de código no se ejecuta
            while (contador > 10)
            {
                Console.WriteLine(contador);
                contador++; // contador = contador + 1
            }

            // El bloque de código se ejecuta una vez.
            do
            {
                Console.WriteLine(contador);
                contador++; // contador = contador + 1
            } while (contador > 10);


            Console.WriteLine("Fin");
        }
    }
}
