using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class TipoDeDatoFunc
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Función que retorna un string pero que no recibe parámetros

            Func<string> retornaString;

            string ObtenerFechayHoraActual()
            {
                return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }

            retornaString = ObtenerFechayHoraActual;
            var resultado = retornaString();
            //Console.WriteLine(resultado);

            void Procesar(Func<string> productorDeValor)
            {
                Console.WriteLine("Línea anterior");
                var valor = productorDeValor();
                Console.WriteLine("El valor es " + valor);
                Console.WriteLine("Línea posterior");
            }

            //Procesar(retornaString);
            //Console.WriteLine();

            // Ejemplo 2: Un Func que recibe parámetros

            Func<int, string> recibeEnteroRetornaString;

            string ObtenerNombreDelMes(int mes)
            {
                var fecha = new DateTime(2022, mes, 1);
                return fecha.ToString("MMMM");
            }

            recibeEnteroRetornaString = ObtenerNombreDelMes;

            var mayo = recibeEnteroRetornaString(5);
            Console.WriteLine(mayo);
        }
    }
}
