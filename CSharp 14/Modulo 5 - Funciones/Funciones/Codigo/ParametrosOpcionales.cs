using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class ParametrosOpcionales
    {
        public void CodigoDeLCurso()
        {
            // Ejemplo 1: Ejemplo sencillo

            void ImprimirEnConsola(string mensaje, bool enMayúsculas = true)
            {
                if (enMayúsculas)
                {
                    mensaje = mensaje.ToUpper();
                }

                Console.WriteLine(mensaje);
            }

            var nombre = "Felipe";
            ImprimirEnConsola(nombre);

            // Ejemplo 2: Usando constantes

            const bool mayúsculas = true;
            void ImprimirEnConsola2(string mensaje, bool enMayúsculas = mayúsculas)
            {
                if (enMayúsculas)
                {
                    mensaje = mensaje.ToUpper();
                }

                Console.WriteLine(mensaje);
            }

            // Ejemplo 3: Usando default

            void ImprimirEnConsola3(string mensaje, bool enMayúsculas = default)
            {
                if (enMayúsculas)
                {
                    mensaje = mensaje.ToUpper();
                }

                Console.WriteLine(mensaje);
            }

            ImprimirEnConsola3("Claudia");
        }
    }
}
