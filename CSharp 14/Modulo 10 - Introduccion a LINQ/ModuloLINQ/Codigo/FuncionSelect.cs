using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class FuncionSelect
    {
        public void CodigoDelCurso()
        {

            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
new Persona { Nombre = "Alejandro", Edad = 25, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
new Persona { Nombre = "Valentina", Edad = 37, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

            // Ejemplo 1: Seleccionar una propiedad
            var nombres = personas.Select(p => p.Nombre).ToList();

            // Ejemplo 2: Seleccionar varias propiedades
            var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad })
                                .ToList();

            // Ejemplo 3: Proyectar hacia una clase
            var personasDTOs = personas
                                .Select(p => new PersonaDTO { Nombre = p.Nombre, Edad = p.Edad })
                                .ToList();

            // Ejemplo 4: Realizar una operación
            var numeros = Enumerable.Range(1, 5).ToList();
            var numerosDuplicados = numeros.Select(n => n * 2).ToList();

            // Ejemplo 5: Tomar el índice

            var nombresConOrden = personas.Select((persona, indice) =>
                    new { Nombre = persona.Nombre, Orden = indice + 1 }).ToList();

            foreach (var item in nombresConOrden)
            {
                Console.WriteLine($"{item.Orden}) {item.Nombre}");
            }
        }
    }
}
