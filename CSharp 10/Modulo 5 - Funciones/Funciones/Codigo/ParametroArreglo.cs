using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class ParametroArreglo
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Pasando un arreglo normal

            double Promedio(int[] numeros)
            {
                var suma = 0.0;
                foreach (var numero in numeros)
                {
                    suma += numero;
                }
                return suma / numeros.Length;
            }

            var promedio1 = Promedio(new int[] { 1, 5, 7, 2 });
            Console.WriteLine("Promedio1: " + promedio1);

            // Ejemplo 2: Pasando un arreglo usando params

            double Promedio2(params int[] numeros)
            {
                var suma = 0.0;
                foreach (var numero in numeros)
                {
                    suma += numero;
                }
                return suma / numeros.Length;
            }

            var promedio2 = Promedio2(1, 5, 7, 2);
            Console.WriteLine("Promedio2: " + promedio2);
        }
    }
}
