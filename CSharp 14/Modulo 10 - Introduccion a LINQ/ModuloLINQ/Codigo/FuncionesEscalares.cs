using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class FuncionesEscalares
    {
        public void CodigoDelCurso()
        {
            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Soltero = true, Edad = 19 },
new Persona { Nombre = "Nidia", Soltero = true, Edad = 25 },
new Persona { Nombre = "Alejandro", Soltero = true, Edad = 30 },
new Persona { Nombre = "Valentina", Soltero = false, Edad = 22 }
};

            // Conteo
            Console.WriteLine($"La cantidad de personas es {personas.Count()}");
            Console.WriteLine(
                    $"La cantidad de personas solteras es {personas.Count(p => p.Soltero)}");
            Console.WriteLine($"El entero más grande es: {int.MaxValue.ToString("N")}");
            Console.WriteLine($"El long más grande es: {long.MaxValue.ToString("N")}");
            Console.WriteLine($"La cantidad de personas es {personas.LongCount()}");

            var numeros = Enumerable.Range(1, 5);

            // Sumar
            var suma = numeros.Sum();
            var sumaEdades = personas.Sum(p => p.Edad);

            // Mínimo

            var mínimo = numeros.Min();
            var edadMinima = personas.Min(p => p.Edad);

            // Máximo

            var máximo = numeros.Max();
            var edadMáxima = personas.Max(p => p.Edad);

            // Promedio

            var promedio = numeros.Average();
            var edadPromedio = personas.Average(p => p.Edad);
        }
    }
}
