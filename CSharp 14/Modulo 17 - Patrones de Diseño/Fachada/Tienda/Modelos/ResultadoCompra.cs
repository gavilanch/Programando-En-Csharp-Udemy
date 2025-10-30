using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Modelos
{
    public record ResultadoCompra(
       bool Exito,
       string Mensaje,
       string? NumeroFactura = null,
       decimal Total = 0m
   );
}
