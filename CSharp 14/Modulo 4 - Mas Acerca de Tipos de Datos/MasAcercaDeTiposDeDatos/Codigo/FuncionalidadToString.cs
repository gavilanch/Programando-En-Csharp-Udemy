using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class FuncionalidadToString
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Simple ToString
            var cantidad1 = 5;

            if (cantidad1.ToString() == "5")
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            // Ejemplo 2: ToString con formato personalizado
            var hoy = DateTime.Today.ToString("yyyy-MM-dd (dddd)");
            Console.WriteLine(hoy);
        }
    }
}
