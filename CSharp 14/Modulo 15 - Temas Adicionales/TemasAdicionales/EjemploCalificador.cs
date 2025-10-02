using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EjemploFelipe = TemasAdicionales.EjemploClaudia;

namespace TemasAdicionales
{
    namespace EjemploFelipe
    {
        internal class EjemploCalificador
        {
            public static string Nombre = "Felipe";

            public static void Imprimir()
            {
                // Felipe
                Console.WriteLine(EjemploFelipe.EjemploCalificador.Nombre);
                // Claudia
                Console.WriteLine(EjemploFelipe::EjemploCalificador.Nombre);
            }

        }
    }

    namespace EjemploClaudia
    {
        internal class EjemploCalificador
        {
            public static string Nombre = "Claudia";
        }
    }

    public class Prueba
    {
        private class System
        {

        }

        public void Imprimir()
        {
            // Error
            //System.Console.WriteLine("Hola");
            // Con esto podemos al namespace raíz
            global::System.Console.WriteLine("Hola");
        }
    }


}
