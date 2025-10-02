using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class CheckedYUnchecked
    {
        public void CodigoDelCurso()
        {
            checked
            {
                var maximo = int.MaxValue;
                var suma = maximo + 1;

                Console.WriteLine(maximo);
                Console.WriteLine(suma);
            }
        }
    }
}
