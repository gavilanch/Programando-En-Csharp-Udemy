using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class IgualdadClasesStructs
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Clases
            var calculadora = new Calculadora();

            var resultadoDT1 = calculadora.CalcularDuploTriplo(5);
            var resultadoDT2 = calculadora.CalcularDuploTriplo(5);

            var sonLasClasesIguales = resultadoDT1 == resultadoDT2; // false

            Console.WriteLine("¿Son las instancias de la clase iguales? " + sonLasClasesIguales);

            // Ejemplo 2: Structs

            var puntoA = new Punto(1, 2);
            var puntoB = new Punto(1, 2);

            // Error
            //var sonLosStructsIguales = puntoA == puntoB;
        }
    }
}
