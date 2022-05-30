using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class NuestroPrimerRecord
    {
        // Este compila a una clase (tipo de referencia)
        internal record Persona
        {
            public Persona(string nombre, string apellido)
            {
                Nombre = nombre;
                Apellido = apellido;
            }

            public string Nombre { get; set; } = "";
            public string Apellido { get; set; } = "";
        }

        // Este compila a un struct (tipo de valor)
        internal record struct Persona_VersionStruct
        {
            public Persona_VersionStruct(string nombre, string apellido)
            {
                Nombre = nombre;
                Apellido = apellido;
            }

            public string Nombre { get; set; } = "";
            public string Apellido { get; set; } = "";
        }

        public void CodigoDelCurso()
        {
            var persona1 = new Persona("Felipe", "Gavilán");

            var persona2 = new Persona("Felipe", "Gavilán");

            var sonIguales = persona1 == persona2; // true

            Console.WriteLine("¿Son los records iguales? " + sonIguales);

            // Es un tipo de referencia
            persona1 = null;
        }
    }
}
