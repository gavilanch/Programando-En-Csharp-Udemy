#pragma warning disable CS0219 // Variable is assigned but its value is never used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class OperadoresBooleanos
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 5;
            var cantidad2 = 5;

            var cantidad1IgualACantidad2 = cantidad1 == cantidad2; // true

            var cantidad1EsDiferenteACantidad2 = cantidad1 != cantidad2; // false

            Console.WriteLine($"Son {cantidad1} y {cantidad2} iguales? {cantidad1IgualACantidad2}");
            Console.WriteLine($"Son {cantidad1} y {cantidad2} diferentes? {cantidad1EsDiferenteACantidad2}");

            var esCantidad1MenorQue10 = cantidad1 < 10; // true
            var esCantidad1MayorQue10 = cantidad1 > 10; // false

            var esCantidad1MenorOIgualQue10 = cantidad1 <= 10; // true
            var esCantidad1MayorOIgualQue10 = cantidad1 >= 10; // false

            string? nombre1 = null;
            var nombre2 = "Felipe";

            var sonLosNombresIguales = nombre1 == nombre2; // true

            var esNombre1Nulo = nombre1 is null; // false
            var esNombre1NoNulo = nombre1 is not null; // true

            Console.WriteLine("Es nombre 1 igual a nulo? " + esNombre1Nulo);
            Console.WriteLine("Es nombre 1 diferente de nulo? " + esNombre1NoNulo);
        }
    }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used