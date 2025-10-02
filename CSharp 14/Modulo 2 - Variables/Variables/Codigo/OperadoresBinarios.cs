using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class OperadoresBinarios
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 7;
            var cantidad2 = 4;
            var resultado = cantidad1 + cantidad2;

            Console.WriteLine("La suma de " + cantidad1 + " y " + cantidad2 + " es igual a: ");
            Console.WriteLine(resultado);

            var nombre = "Felipe";
            var apellido = "Gavilán";

            var resultadoString = nombre + apellido;

            Console.WriteLine("Podemos concatenar strings con +");
            Console.WriteLine(resultadoString);
        }
    }
}
