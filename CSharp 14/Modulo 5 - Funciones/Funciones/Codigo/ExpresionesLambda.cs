using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class ExpresionesLambda
    {
        public void CodigoDelCurso()
        {
            var suma = Sumar(1, 2); // 3
        }

        // El "=>" se llama operador lambda
        int Sumar(int a, int b) => a + b;
    }
}
