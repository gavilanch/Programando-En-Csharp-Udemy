using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores.Codigo
{
    internal class ContenidoDeVariables
    {
        public void CodigoDelCurso()
        {
            Procesar(7, "Gavilán");

            void Procesar(int a, string apellido)
            {
                var tupla = (a, apellido);
                a = 3;
                int b = a + 8;
                b -= 4;
                int[] numeros = { 1, 2, 3 };
            }

        }
    }
}
