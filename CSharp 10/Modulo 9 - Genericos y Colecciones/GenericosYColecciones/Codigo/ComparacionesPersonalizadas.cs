using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones.Codigo
{
    internal class ComparacionesPersonalizadas
    {
        public void CodigoDelCurso()
        {
            var Felipe = new Persona { Nombre = "Felipe", Edad = 20 };
            var Claudia = new Persona { Nombre = "Claudia", Edad = 21 };

            var valor = Felipe.CompareTo(Claudia); // -1
                                                   //Console.WriteLine(valor);

            var personas = new List<Persona>()
{
    Claudia,
    new Persona(){Nombre = "Roberto", Edad = 15},
    new Persona(){Nombre = "Lorena", Edad = 25},
    new Persona(){Nombre = "Mario", Edad = 22},
    Felipe,
    new Persona(){Nombre = "Esvetlana", Edad = 15}
};

            personas.Sort();

            Console.WriteLine("Ordenando por edad: ");

            foreach (var persona in personas)
            {
                Console.WriteLine($"- {persona.Nombre} (Edad: {persona.Edad})");
            }

            // Ordenando por nombre

            personas.Sort(new ComparadorPersonasPorNombre());

            Console.WriteLine();

            Console.WriteLine("Ordenando por nombre: ");

            foreach (var persona in personas)
            {
                Console.WriteLine($"- {persona.Nombre} (Edad: {persona.Edad})");
            }

        }
    }
}
