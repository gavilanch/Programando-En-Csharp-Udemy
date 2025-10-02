using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class AlcanceDeLasVariables
    {
        public void CodigoDelCurso()
        {
            string nombre = "Felipe";

            void ImprimirFechaYHoraActual()
            {
                nombre = "Claudia";
                var fechaYHora = DateTime.Now;
                for (int i = 0; i < 3; i++)
                {
                    var mensaje = $"Hoy es {fechaYHora.ToString("yyyy-MM-dd hh:mm:ss")}";
                    Console.WriteLine(mensaje);
                }

                //Console.WriteLine(mensaje); // Error: No puedo usar la variable mensaje aquí
            }

            ImprimirFechaYHoraActual();
            Console.WriteLine(nombre); // Claudia
        }
    }
}
