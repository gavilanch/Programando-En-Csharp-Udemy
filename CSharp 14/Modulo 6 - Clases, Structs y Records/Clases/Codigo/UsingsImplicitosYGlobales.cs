//global using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class UsingsImplicitosYGlobales
    {
        public void CodigoDelCurso()
        {
            // Podemos usar la clase Console pues hay un using implícito de System.
            Console.WriteLine("¿Dónde está el using System;?");

            var calculadora = new Calculadora();
        }
    }
}
