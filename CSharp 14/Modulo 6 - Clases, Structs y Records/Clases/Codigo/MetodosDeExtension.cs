using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal static class ExtensionesString
    {
        internal static int ContarPalabras(this string? s, int valorPorDefecto = -1)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return valorPorDefecto;
            }

            var separadores = new string[] { " ", Environment.NewLine };
            var palabras = s.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            return palabras.Length;
        }
    }

    internal class MetodosDeExtension
    {
        public void CodigoDelCurso()
        {
            var mensaje = @"Este es un mensaje, 

atentamente: felipe";

            // Podemos usar null para probar el valor por defecto
            //string? mensaje = null;

            // Usando método de extensión
            var cantidadPalabras = mensaje.ContarPalabras(valorPorDefecto: -2);

            // Sin usar método de extensión
            //var cantidadPalabras_V2 = ExtensionesString.ContarPalabras(mensaje);

            Console.WriteLine("Cantidad palabras " + cantidadPalabras);
        }
    }
}
