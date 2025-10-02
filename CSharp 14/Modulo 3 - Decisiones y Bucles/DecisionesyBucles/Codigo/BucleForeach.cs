using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class BucleForeach
    {
        public void CodigoDelCurso()
        {
            var nombre = "Felipe";

            foreach (var letra in nombre)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
