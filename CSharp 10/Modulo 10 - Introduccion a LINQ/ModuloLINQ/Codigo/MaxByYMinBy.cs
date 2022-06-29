using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class MaxByYMinBy
    {
        public void CodigoDelCurso()
        {
            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", Soltero = true, Edad = 19 },
new Persona { Nombre = "Nidia", Soltero = true, Edad = 25 },
new Persona { Nombre = "Alejandro", Soltero = true, Edad = 30 },
new Persona { Nombre = "Valentina", Soltero = false, Edad = 22 }
};

            // Mínimo
            var edadMinima = personas.Min(p => p.Edad);
            var personaConLaEdadMásPequeña = personas.MinBy(p => p.Edad);

            // Máximo
            var edadMáxima = personas.Max(p => p.Edad);
            var personaConLaEdadMásGrande = personas.MaxBy(p => p.Edad);

        }
    }
}
