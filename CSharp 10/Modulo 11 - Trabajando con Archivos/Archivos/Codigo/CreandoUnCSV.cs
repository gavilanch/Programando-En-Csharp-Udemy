using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class CreandoUnCSV
    {
        public void CodigoDelCurso()
        {
            var rutaEjemplo = @"..\..\..\personas.csv";

            var personas = new List<Persona>
{
    new Persona(){Id = 1, Nombre = "Felipe Gavilán", Salario = 25.9m},
    new Persona(){Id = 2, Nombre = "Claudia Rodríguez", Salario = 155m},
    new Persona(){Id = 3, Nombre = "Roberto Gonzalez", Salario = 42m},
    new Persona(){Id = 4, Nombre = "Mariana Reyes", Salario = 39m},
    new Persona(){Id = 5, Nombre = "Arturo Aristy", Salario = 50m},
};

            var stringBuilder = new StringBuilder();

            foreach (var persona in personas)
            {
                stringBuilder.AppendLine($"{persona.Id},{persona.Nombre},{persona.Salario}");
            }

            using (var sw = new StreamWriter(rutaEjemplo, append: false, Encoding.UTF8))
            {
                sw.Write(stringBuilder.ToString());
            }
        }
    }
}
