using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class FuncionesAnonimas
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Una simple función anónima

            Action imprimirMensaje = () =>
            {
                Console.WriteLine(DateTime.Now.ToString());
            };

            //imprimirMensaje();

            // Ejemplo 2: Pasando una función anónima como parámetro

            void Procesar(Action acción)
            {
                Console.WriteLine("Antes de ejecutar la acción");
                acción();
                Console.WriteLine("Después de ejecutar la acción");
            }

            Procesar(() =>
            {
                Console.WriteLine(DateTime.Now.ToString());
            });

            // Ejemplo 3: Función anónima que recibe un parámetro y retorna un valor

            Func<int, int> duplicar = a => 2 * a;
            var duplicarV2 = (int a) => 2 * a;

            // Ejemplo 4: Función anónima que reciba 2 parámetros y retorna un valor

            Func<bool, string, int> ejemplo = (bool1, string1) =>
            {
                return 42;
            };

            var ejemploV2 = (bool bool1, string string1) =>
            {
                return 42;
            };
        }
    }
}
