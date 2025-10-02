using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class FirstYFirstOrDefault
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

            // Ejemplo simple

            var primeraPersona = personas.First();
            var primeraPersona_2 = personas.FirstOrDefault();

            // ¿Qué ocurre con una colección vacía?
            var paises = new List<string>();

            //var primerPais = paises.First();
            var primerPais2 = paises.FirstOrDefault();

            // Agregando filtros
            var primeraPersonaMenorDe25 = personas.First(p => p.Edad < 25);
            var primeraPersonaMayorDe100 = personas.FirstOrDefault(p => p.Edad > 100);

            if (primeraPersonaMayorDe100 is null)
            {
                Console.WriteLine("No hay ninguna persona mayor de 100");
            }

            // Combinar funciones de LINQ
            var primeraPersonaMayorDe60 = personas.Where(p => p.Edad > 60).FirstOrDefault();

            var numeros = new List<int>();
            var primerNumero = numeros.FirstOrDefault();

        }
    }
}
