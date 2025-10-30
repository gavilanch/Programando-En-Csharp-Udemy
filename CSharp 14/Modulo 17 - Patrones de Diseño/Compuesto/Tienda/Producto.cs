using System;
using System.Collections.Generic;
using System.Text;

namespace Compuesto.Tienda
{
    public class Producto: IItemCarrito
    {
        public string Nombre { get; }
        public decimal Precio { get; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void Imprimir(int nivel = 0)
        {
            var espacioIzquierdo = "".PadLeft(nivel * 2, ' ');
            Console.WriteLine($"{espacioIzquierdo}- {Nombre}: {Precio.ToString("C")}");
        }
    }

}
