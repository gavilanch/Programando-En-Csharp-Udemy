using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class FuncionSelectMany
    {
        public void CodigoDelCurso()
        {
            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Telefonos = { "123-456", "789-852" } },
new Persona { Nombre = "Nidia", Telefonos = { "998-478", "568-222" } },
new Persona { Nombre = "Alejandro", Telefonos = { "712-132" } },
new Persona { Nombre = "Valentina" }
};

            // Ejemplo 1: Seleccionar telefonos sin personas

            var telefonos = personas.SelectMany(p => p.Telefonos).ToList();

            // Ejemplo 2: Entendiendo SelectMany con dos colecciones diferentes

            int[] numeros = { 1, 2, 3 };

            var personasYNumeros = personas.SelectMany(p => numeros, (persona, numero) => new
            {
                Persona = persona,
                Numero = numero
            });

            foreach (var item in personasYNumeros)
            {
                Console.WriteLine($"{item.Persona.Nombre} - {item.Numero}");
            }

            // Ejemplo 3: personas y telefonos

            var personasYTelefonos = personas.SelectMany(p => p.Telefonos, (persona, telefono) =>
            new {
                Nombre = persona.Nombre,
                Telefono = telefono
            });

            foreach (var item in personasYTelefonos)
            {
                Console.WriteLine($"{item.Nombre} - {item.Telefono}");
            }

        }
    }
}
