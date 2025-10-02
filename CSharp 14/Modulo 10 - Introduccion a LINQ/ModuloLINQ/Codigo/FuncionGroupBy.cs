using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class FuncionGroupBy
    {
        public void CodigoDelCurso()
        {
            var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
    new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
    new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
    new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
};

            var agrupamientoPorSoltería = personas.GroupBy(p => p.Soltero);

            foreach (var grupo in agrupamientoPorSoltería)
            {
                Console.WriteLine($"Grupo de las personas donde Soltero = {grupo.Key} (Total: {grupo.Count()})");

                foreach (var persona in grupo)
                {
                    Console.WriteLine($"- {persona.Nombre}");
                }
            }

        }
    }
}
