using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class ParametrosOut
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: introducción a out

            int cantidad;

            void DuplicarYTriplicar(int operando, out int resultadoDuplo, out int resultadoTriplo)
            {
                resultadoDuplo = operando * 2;
                resultadoTriplo = operando * 3;
            }

            int resultadoDuplo, resultadoTriplo;

            DuplicarYTriplicar(3, out resultadoDuplo, out resultadoTriplo);
            Console.WriteLine("El doble es: " + resultadoDuplo);
            Console.WriteLine("El triple es: " + resultadoTriplo);

            // Ejemplo 2: TryParse

            int numero;
            string numeroString = "7";

            if (int.TryParse(numeroString, out numero))
            {
                Console.WriteLine("El número es " + numero);
            }
            else
            {
                Console.WriteLine("Formato incorrecto");
            }
        }
    }
}
