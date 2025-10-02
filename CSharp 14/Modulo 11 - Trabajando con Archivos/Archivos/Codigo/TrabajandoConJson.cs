using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class TrabajandoConJson
    {
        public void CodigoDelCurso()
        {
            var rutaEjemplo = @"..\..\..\personas.json";

            var persona = new Persona { Id = 1, Nombre = "Felipe Gavilán", Salario = 25.99m };

            var json = JsonConvert.SerializeObject(persona);

            using (var sw = new StreamWriter(rutaEjemplo))
            {
                sw.Write(json);
            }

            var contenidoArchivo = File.ReadAllText(rutaEjemplo);
            var personaDeserializada = JsonConvert.DeserializeObject<Persona>(contenidoArchivo)!;
            Console.WriteLine(personaDeserializada.Nombre);
        }
    }
}
