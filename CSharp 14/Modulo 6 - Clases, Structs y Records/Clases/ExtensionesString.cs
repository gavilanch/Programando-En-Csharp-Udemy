using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
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
}
