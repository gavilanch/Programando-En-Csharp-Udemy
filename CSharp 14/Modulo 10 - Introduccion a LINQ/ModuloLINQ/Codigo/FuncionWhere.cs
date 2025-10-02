using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class FuncionWhere
    {
        public void CodigoDelCurso()
        {
            int[] numeros = Enumerable.Range(1, 20).ToArray();

            var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();

            var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

            // Ejemplo 2: Colección de objetos

            var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

            var personasDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();

            //foreach (var persona in personasDe25AñosOMenos)
            //{
            //    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años.");
            //}

            var solteros = personas.Where(p => p.Soltero).ToList();

            //foreach (var persona in solteros)
            //{
            //    Console.WriteLine($"{persona.Nombre} es soltero/a");
            //}

            var solterosMenoresDe25 = personas.Where(p => p.Edad <= 25 && p.Soltero).ToList();

            foreach (var persona in solterosMenoresDe25)
            {
                Console.WriteLine($"{persona.Nombre} es soltero/a y es menor de 25.");
            }

            var fechaActual = DateTime.Today;

            var personasConMenosDe3MesesEnLaEmpresa = personas.Where(p =>
            p.FechaIngresoALaEmpresa >= fechaActual.AddMonths(-3)).ToList();

            foreach (var persona in personasConMenosDe3MesesEnLaEmpresa)
            {
                Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa.");
            }


            Console.WriteLine();
        }
    }
}
