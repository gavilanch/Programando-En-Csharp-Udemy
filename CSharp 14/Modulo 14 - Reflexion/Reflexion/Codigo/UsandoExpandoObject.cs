using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion.Codigo
{
    internal class UsandoExpandoObject
    {
        public void CodigoDelCurso()
        {
            dynamic objetoExpandible = new ExpandoObject();

            objetoExpandible.Nombre = "Felipe";

            Console.WriteLine(objetoExpandible.Nombre);

            objetoExpandible.Apellido = "Gavilán";

            Console.WriteLine(objetoExpandible.Apellido);

            objetoExpandible.Sumar = new Func<int, int, int>((int a, int b) => a + b);

            Console.WriteLine(objetoExpandible.Sumar(1, 2));

            var diccionario = (IDictionary<string, object>)objetoExpandible;

            Console.WriteLine(diccionario["Nombre"]);

            foreach (var llave in diccionario.Keys)
            {
                Console.WriteLine(llave);
            }

            diccionario.Remove("Apellido");

            try
            {
                Console.WriteLine(objetoExpandible.Apellido);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La propiedad apellido no existe en el ExpandoObject");
            }
        }
    }
}
