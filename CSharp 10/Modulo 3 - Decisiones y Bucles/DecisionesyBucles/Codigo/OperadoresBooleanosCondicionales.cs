using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class OperadoresBooleanosCondicionales
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 7;

            // true && true => true
            // true && false => false 
            // false && true => false 
            // false && false => false 
            var estaEntre5y10 = cantidad1 > 5 && cantidad1 < 10; // true
            Console.WriteLine($"¿Está el {cantidad1} entre 5 y 10? {estaEntre5y10}");

            // true || true => true
            // true || false => true
            // false || true => true
            // false || false => false
            var cantidad1Es5o6 = cantidad1 == 5 || cantidad1 == 6; // true
            Console.WriteLine($"¿Es {cantidad1} igual a 5 o 6? {cantidad1Es5o6}");

            string? apellido = null;

            var estaElApellidoEnMayusculas = apellido is not null && apellido == apellido.ToUpper();

            Console.WriteLine("Está el string en mayúsculas? " + estaElApellidoEnMayusculas);

        }
    }
}
