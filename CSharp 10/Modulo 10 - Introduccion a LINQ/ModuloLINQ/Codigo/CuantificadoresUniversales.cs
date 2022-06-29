using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class CuantificadoresUniversales
    {
        public void CodigoDelCurso()
        {
            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
new Persona { Nombre = "Valentina", Edad = 17, Soltero = false }
};

            // Ejemplo: All
            var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);

            var sonTodosSolteros = personas.All(p => p.Soltero);

            // Ejemplo: Any
            var existeMenor = personas.Any(p => p.Edad < 18);

            var existePersonaMayorDe35 = personas.Any(p => p.Edad > 35);

            // Ejemplo: Contains

            var numeros = Enumerable.Range(1, 5);

            var estaElNumero3 = numeros.Contains(3);
            var estaElNumero20 = numeros.Contains(20);
        }
    }
}
