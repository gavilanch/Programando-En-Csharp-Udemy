using System;
using System.Collections.Generic;
using System.Text;

namespace Compuesto.Tienda
{
    public class Carrito
    {
        private readonly List<IItemCarrito> _items = [];

        public void Agregar(IItemCarrito item) => _items.Add(item);

        public void Remover(IItemCarrito item) => _items.Remove(item);

        public void Limpiar()
        {
            _items.Clear();
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var item in _items)
            {
                total += item.Precio;
            }

            return total;

        }

        public void ImprimirResumen()
        {
            Console.WriteLine("=== Carrito ===");
            foreach (var item in _items)
            {
                item.Imprimir();
            }
            Console.WriteLine($"TOTAL: {CalcularTotal().ToString("C")}");
        }

    }
}
