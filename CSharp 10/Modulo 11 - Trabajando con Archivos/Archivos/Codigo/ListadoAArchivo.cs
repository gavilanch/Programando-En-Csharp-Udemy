using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class ListadoAArchivo
    {
        string ruta = @"..\..\..\personas.txt";

        public void CodigoDelCurso()
        {
            
            var personas = new List<Persona>
{
    new Persona(){Id = 1, Nombre = "Felipe Gavilán", Salario = 25.99m},
    new Persona(){Id = 2, Nombre = "Claudia Rodríguez", Salario = 155m},
    new Persona(){Id = 3, Nombre = "Roberto Gonzalez", Salario = 42m},
    new Persona(){Id = 4, Nombre = "Mariana Reyes", Salario = 39m},
    new Persona(){Id = 5, Nombre = "Arturo Aristy", Salario = 50m},
};

            // Ejemplo 1: Separando por |
            SeparandoPorPipe(personas);

            // Ejemplo 2: Separando por espacios
            SeparandoPorEspacios(personas);

            
        }

        private void SeparandoPorPipe(List<Persona> personas)
        {
            var stringBuilder = new StringBuilder();

            foreach (var persona in personas)
            {
                stringBuilder.AppendLine($"{persona.Id}|{persona.Nombre}|{persona.Salario}");
            }

            using (var sw = new StreamWriter(ruta, append: false))
            {
                sw.Write(stringBuilder.ToString());
            }
        }

        private void SeparandoPorEspacios(List<Persona> personas)
        {
            var stringBuilder = new StringBuilder();
            foreach (var persona in personas)
            {
                var id = persona.Id.ToString().PadLeft(10, '0');
                var nombre = persona.Nombre.PadLeft(75);
                var salario = persona.Salario.ToString("N2").Replace(".", "").PadLeft(10, '0');
                stringBuilder.AppendLine($"{id}{nombre}{salario}");
            }

            using (var sw = new StreamWriter(ruta, append: false))
            {
                sw.Write(stringBuilder.ToString());
            }
        }
    }
}
