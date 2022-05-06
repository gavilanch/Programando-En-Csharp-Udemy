using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class OperacionesUnarias
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 7;
            var cantidad2 = 5;

            var cantidad1PorMenos1 = -cantidad1; // (-1) * cantidad1

            //Console.WriteLine(cantidad1PorMenos1);

            cantidad1++; // cantidad1 = cantidad1 + 1
            cantidad1--; // cantidad1 = cantidad1 - 1

            //++cantidad1; // cantidad1 = cantidad1 + 1
            //--cantidad1; // cantidad1 = cantidad1 - 1

            // Ojo: Lo ideal es dividir estas operaciones en varias líneas para que sea más legible
            var suma = cantidad1++ + cantidad2; // 7 + 5 = 12
            // operación 1 => suma = cantidad1 + cantidad2;
            // operación 2 => cantidad1 = cantidad1 + 1

            var suma2 = ++cantidad1 + cantidad2; // 8 + 5 = 13
            // operación 1 => cantidad1 = cantidad1 + 1
            // operación 2 => suma = cantidad1 + cantidad2;

            Console.WriteLine("suma es " + suma); 
            Console.WriteLine("cantidad1 es " + cantidad1);
        }
    }
}
