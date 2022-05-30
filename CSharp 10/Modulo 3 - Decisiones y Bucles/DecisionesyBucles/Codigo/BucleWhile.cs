using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class BucleWhile
    {
        public void CodigoDelCurso()
        {
            int contador = 1;

            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador++; // contador = contador + 1
            }

            var balance = 200m;
            var interés = 1.07m;
            var contadorInterés = 1;

            while (contadorInterés <= 20)
            {
                balance *= interés;
                contadorInterés++;
            }

            Console.WriteLine(balance);
        }
    }
}
