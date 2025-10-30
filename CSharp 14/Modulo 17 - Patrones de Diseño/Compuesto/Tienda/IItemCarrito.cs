using System;
using System.Collections.Generic;
using System.Text;

namespace Compuesto.Tienda
{
    public interface IItemCarrito
    {
        string Nombre { get; }
        decimal Precio { get; }
        void Imprimir(int nivel = 0);
    }
}
