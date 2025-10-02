using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class OrderByYOrderByDescending
    {
        public void CodigoDelCurso()
        {
            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

            // Ejemplo 1: Ordenando por edad de manera ascendente

            foreach (var persona in personas.OrderBy(p => p.Edad))
            {
                Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
            }

            // Ejemplo 2: Ordenando por edad de manera descendente

            foreach (var persona in personas.OrderByDescending(p => p.Edad))
            {
                Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
            }

            // Ejemplo 3: Ordenando numeros
            int[] numeros = { 1, 5, 12, 2, 3, 111, 6 };

            var numerosOrdenados = numeros.OrderBy(n => n).ToList();

            foreach (var numero in numerosOrdenados)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
