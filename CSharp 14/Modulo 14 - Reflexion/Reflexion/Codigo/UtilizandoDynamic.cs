using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion.Codigo
{
    internal class UtilizandoDynamic
    {
        public void CodigoDelCurso()
        {
            dynamic nombre = "Felipe";
            Console.WriteLine(nombre);
            Console.WriteLine(nombre.ToUpper());

            nombre = 99;
            Console.WriteLine(nombre);
            Console.WriteLine(nombre.ToUpper());

            var contenidoJSON = File.ReadAllText(@"..\..\..\persona.json");

            dynamic obj = JsonConvert.DeserializeObject<dynamic>(contenidoJSON)!;

            Console.WriteLine(obj.nombre);
            Console.WriteLine(obj.direcciones[0].calle);
        }
    }
}
