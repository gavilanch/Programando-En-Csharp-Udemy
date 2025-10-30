using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Modelos
{
    public record Carrito(int ClienteId, List<ItemCarrito> Items);
}
