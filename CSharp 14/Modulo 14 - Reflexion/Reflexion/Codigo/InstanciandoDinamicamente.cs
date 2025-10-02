using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion.Codigo
{
    internal class InstanciandoDinamicamente
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Instanciando una clase por el tipo

            Type tipo = typeof(Persona);
            var personaSinNombreViaType = (Persona)Activator.CreateInstance(tipo)!;

            //Console.WriteLine("Persona instanciada por el type " + personaSinNombreViaType);

            // Ejemplo 2: Instanciando una clase por su nombre y assembly

            var nombreCompletoClasePersona = typeof(Persona).FullName!;
            var assemblyClasePersona = typeof(Persona).Assembly.GetName().Name!;

            var personaSinNombreViaString = (Persona)Activator.CreateInstance(assemblyClasePersona,
                nombreCompletoClasePersona)!.Unwrap()!;

            Console.WriteLine("Persona instanciada por un string " + personaSinNombreViaString);

            // Ejemplo 3: Instanciando una clase pasándole valores al constructor

            var personaConNombreViaType = (Persona)Activator.CreateInstance(typeof(Persona),
                new object[] { "Felipe Gavilán" })!;

            Console.WriteLine("El nombre de la persona es " + personaConNombreViaType.Nombre);
        }
    }
}
