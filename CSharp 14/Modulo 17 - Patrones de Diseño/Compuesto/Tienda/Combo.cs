using System;
using System.Collections.Generic;
using System.Text;

namespace Compuesto.Tienda
{
    public class Combo: IItemCarrito
    {
        public string Nombre { get; }
        public List<IItemCarrito> Items { get; } = [];
        public decimal Descuento { get; }
        public decimal Precio => Items.Sum(p => p.Precio) * Descuento;

        public Combo(string nombre, decimal descuento = 0.95m)
        {
            Nombre = nombre;
            Descuento = descuento;
        }

        public void Agregar(IItemCarrito item) => Items.Add(item);

        public void Remover(IItemCarrito item) => Items.Remove(item);

        public void Imprimir(int nivel = 0)
        {
            var espacioIzquierdo = "".PadLeft(nivel * 2, ' ');
            Console.WriteLine($"{espacioIzquierdo}+ {Nombre} (Total: {Precio.ToString("C")}) (Aplicado descuento: {100 * (1 - Descuento)}%)");

            foreach (var item in Items)
            {
                item.Imprimir(nivel + 1);
            }
        
        }
    }

}
