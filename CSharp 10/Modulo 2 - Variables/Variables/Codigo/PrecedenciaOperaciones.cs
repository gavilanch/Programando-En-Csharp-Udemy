using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class PrecedenciaOperaciones
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 1;
            var cantidad2 = 2;
            var cantidad3 = 3;

            var cantidad4 = cantidad1 + cantidad2 + cantidad3; // 6

            // La multiplicación se hace primero
            var cantidad5 = cantidad1 + cantidad2 * cantidad3; // 7

            var cantidad6 = (cantidad1 + cantidad2) * cantidad3; // 9

            // No hagas esto, por favor!
            // Lo mejor es separar esto en distintas líneas
            var cantidad7 = (++cantidad1 + cantidad2++) * (++cantidad3 + --cantidad3); // ??

            // Y si tampoco se entiende así, se puede separar en más líneas
            var cantidad8 = ++cantidad1 + cantidad2++;
            var cantidad9 = ++cantidad3 + --cantidad3;
            var cantidad10 = cantidad8 * cantidad9;

            Console.WriteLine(cantidad10);
        }
    }
}
