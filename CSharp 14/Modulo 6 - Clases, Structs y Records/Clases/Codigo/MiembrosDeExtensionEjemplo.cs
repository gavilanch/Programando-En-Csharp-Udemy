using System;
using System.Collections.Generic;
using System.Text;

namespace Clases.Codigo
{
    internal class MiembrosDeExtensionEjemplo
    {
        public void EjemploDelCurso()
        {
            Console.WriteLine($"Aquí un ejemplo de un string vacío: {string.Vacio}");

            string? nombre = "Felipe";

            Console.WriteLine($"¿Es {nombre} nulo o vacío? {nombre.EsNuloOVacio}");
            Console.WriteLine($"Cantidad de palabras de {nombre}: {nombre.ContarPalabras2()}");
        }    
    }

    internal static class MiembrosDeExtension
    {
        // Bloque de extensión
        extension(string valor)
        {
            // Propiedad de extensión estática
            public static string Vacio => string.Empty;

            // Error
            //public string Etiqueta { get; set; }

            // Propiedad de extensión
            public bool EsNuloOVacio => string.IsNullOrEmpty(valor);

            // Método de extensión
            public int ContarPalabras2(int valorPorDefecto = -1)
            {
                if (string.IsNullOrWhiteSpace(valor))
                {
                    return valorPorDefecto;
                }

                var separadores = new string[] { " ", Environment.NewLine };
                var palabras = valor.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

                return palabras.Length;
            }

        }
    }
}
