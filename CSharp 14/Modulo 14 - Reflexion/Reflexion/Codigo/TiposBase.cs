using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion.Codigo
{
    internal class TiposBase
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Obteniendo el tipo base

            var tipoBaseString = typeof(string).BaseType;
            var tipoBaseCarro = typeof(Carro).BaseType;

            Console.WriteLine($"La clase base de string es {tipoBaseString}");
            Console.WriteLine($"La clase base de carro es {tipoBaseCarro}");


            // Ejemplo 2: Obteniendo las interfaces de un tipo

            Console.WriteLine("Las interfaces de string son: ");

            foreach (var interfaz in typeof(string).GetInterfaces())
            {
                Console.WriteLine("- " + interfaz);
            }

            // Ejemplo 3: Viendo si un tipo hereda de una interfaz o clase

            var tipoString = typeof(string);
            var tipoIEnumerable = typeof(IEnumerable);

            Console.WriteLine("¿String hereda de IEnumerable? " + tipoString.IsAssignableTo(tipoIEnumerable));

            Console.WriteLine(
                "¿IEnumerable es implementada por string? " + tipoIEnumerable.IsAssignableFrom(tipoString));

            Console.WriteLine("¿Carro hereda de Vehiculo? " + typeof(Carro).IsAssignableTo(typeof(Vehiculo)));
            Console.WriteLine("¿Carro hereda de IEnumerable? " + typeof(Carro).IsAssignableTo(tipoIEnumerable));
        }
    }
}
