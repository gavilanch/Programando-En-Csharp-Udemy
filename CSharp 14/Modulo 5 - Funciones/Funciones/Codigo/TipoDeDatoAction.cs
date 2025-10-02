using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class TipoDeDatoAction
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Función void que no recibe parámetros

            Action imprimeMensaje;

            void ImprimirFechaYHora()
            {
                Console.WriteLine(DateTime.Now.ToString());
            }

            void ImprimirMiNombre()
            {
                Console.WriteLine("Felipe");
            }

            imprimeMensaje = ImprimirFechaYHora;
            imprimeMensaje();

            imprimeMensaje = ImprimirMiNombre;
            imprimeMensaje();

            void Procesar(Action action)
            {
                Console.WriteLine("Antes de ejecutar el action");
                action();
                Console.WriteLine("Después de ejecutar el action");
            }

            imprimeMensaje = ImprimirFechaYHora;
            Procesar(imprimeMensaje);
            Console.WriteLine();
            Procesar(ImprimirMiNombre);

            // Ejemplo 2: Funcion void que recibe un parámetro

            Action<int> alterarNumero;

            void Sumar1(int valor)
            {
                valor++;
                Console.WriteLine("El valor + 1 es " + valor);
            }

            alterarNumero = Sumar1;
            alterarNumero(5);

            // Ejemplo 3: Función void que recibe 2 parámetros

            Action<string, int> imprimirNVeces;

            void Imprimir(string mensaje, int veces)
            {
                for (int i = 0; i < veces; i++)
                {
                    Console.WriteLine(mensaje);
                }
            }

            imprimirNVeces = Imprimir;
            imprimirNVeces("Felipe", 4);
        }
    }
}
