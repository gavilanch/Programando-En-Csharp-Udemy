using Puente.Descuentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puente.Ventas
{
    internal abstract class Venta
    {
        protected IDescuento Descuento { get; }

        protected Venta(IDescuento descuento)
        {
            Descuento = descuento;
        }

        internal abstract void Pagar(decimal monto);

    }
}
