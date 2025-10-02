using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales
{
    internal static class Utilidades
    {
        public static Dictionary<string, List<string>> ExtraerErroresDelWebAPI(string json)
        {
            var respuesta = new Dictionary<string, List<string>>();

            var deserializado = JsonConvert.DeserializeObject<dynamic>(json)!;
            var campoErrores = deserializado.errors;

            foreach (dynamic campoConErrores in campoErrores)
            {
                var campo = campoConErrores.Name;
                var errores = new List<string>();
                foreach (var error in campoConErrores.Value)
                {
                    errores.Add(error.ToString());
                }
                respuesta.Add(campo, errores);
            }

            return respuesta;
        }
    }
}
