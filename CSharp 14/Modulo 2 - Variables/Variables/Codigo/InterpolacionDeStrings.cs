using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class InterpolacionDeStrings
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 7;
            var cantidad2 = 4;
            var resultado = cantidad1 + cantidad2;
            var nombre = "Felipe";

            Console.WriteLine("La suma de " + cantidad1 + " y " + cantidad2 + " es igual a: " + resultado);
            Console.WriteLine($"Las suma de {cantidad1} y {cantidad2} es igual a: {cantidad1 + cantidad2}");

            Console.WriteLine($"Mi nombre es {nombre.ToUpper()} en mayúsculas");
        }
    }
}
