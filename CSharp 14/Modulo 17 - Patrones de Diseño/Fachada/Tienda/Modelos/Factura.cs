using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Modelos
{
    public record Factura(string Numero, int ClienteId, decimal Total, DateTime Fecha);
}
