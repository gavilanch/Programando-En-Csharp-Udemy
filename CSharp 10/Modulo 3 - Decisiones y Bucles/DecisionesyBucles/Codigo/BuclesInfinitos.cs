using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class BuclesInfinitos
    {
        public void CodigoDelCurso()
        {
            // Ejemplo de bucle infinito con while
            //while (true)
            //{
            //    Console.WriteLine("Este código no se detiene.");
            //}

            // Ejemplo de bucle infinito con for
            //for(; ; )
            //{
            //    Console.WriteLine("Este código tampoco se detiene");
            //}

            // Programa de suma de números
            while (true)
            {
                Console.WriteLine("Te damos la bienvenida a la calculadora de suma con C#!");
                Console.Write("Escriba el primer número: ");
                var entradaUsuario = Console.ReadLine();

                if (entradaUsuario is null)
                {
                    Console.WriteLine("Error. Vuelve a comenzar");
                    continue;
                }

                var numero1 = decimal.Parse(entradaUsuario); // Cuidado, podría lanzar una excepción

                Console.Write("Escriba el segundo número: ");
                entradaUsuario = Console.ReadLine();

                if (entradaUsuario is null)
                {
                    Console.WriteLine("Error. Vuelve a comenzar");
                    continue;
                }

                var numero2 = decimal.Parse(entradaUsuario);

                Console.WriteLine($"El resultado de sumar {numero1} y {numero2} es {numero1 + numero2}");
                Console.Write("¿Desea sumar otra vez? (y/n) ");
                entradaUsuario = Console.ReadLine();

                if (entradaUsuario != "y")
                {
                    break;
                }

            }

            Console.WriteLine("Adiós!");
        }
    }
}
