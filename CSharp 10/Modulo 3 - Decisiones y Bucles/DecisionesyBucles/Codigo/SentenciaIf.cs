using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class SentenciaIf
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 1;

            if (cantidad1 > 5)
            {
                Console.WriteLine("Es mayor a 5");
            }
            else if (cantidad1 == 3)
            {
                Console.WriteLine("El valor es 3!");
            }
            else
            {
                Console.WriteLine("Es menor o igual a 5");
            }

            Console.WriteLine("Fin");
        }
    }
}
