using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class DeclarandoFunciones
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Funciones simples.

            string ObtenerNombre()
            {
                // return 42; // Error: no puedo retornar int
                return "Claudia";
            }

            var miNombre = ObtenerNombre();

            var miNombre2 = ObtenerNombre();

            Console.WriteLine("Nombre 1: " + miNombre);
            Console.WriteLine("Nombre 2: " + miNombre2);

            // Ejemplo 2: Función que no retorna nada

            void ImprimirFechaYHoraActual()
            {
                var fechaYHora = DateTime.Now;
                var mensaje = $"Hoy es {fechaYHora.ToString("yyyy-MM-dd hh:mm:ss")}";
                Console.WriteLine(mensaje);
            }

            ImprimirFechaYHoraActual();
        }
    }
}
