using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores.Codigo
{
    internal class BreakpointsCondicionales
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Breakpoints condicionales por expresión
            var apellido = "Gavilán";

            Sumar(4, 6); // a < b (no se va activar)
            Sumar(5, 10); // a < b
            Sumar(7, 1); // a > b (se va a ejecutar)
            Sumar(7, 2); // a > b 
            Sumar(3, 7); // a < b (se va a ejecutar)

            int Sumar(int a, int b)
            {
                int c = a + b;
                return c;
            }

            // Ejemplo 2: Breakpoints condicionales por conteo

            int[] numeros = { 10, 20, 30, 40, 50, 60 };

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
