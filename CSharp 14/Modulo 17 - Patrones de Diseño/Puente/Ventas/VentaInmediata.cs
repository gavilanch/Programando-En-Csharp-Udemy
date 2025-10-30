using Puente.Descuentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Puente.Ventas
{
    internal class VentaInmediata : Venta
    {
        public VentaInmediata(IDescuento descuento) : base(descuento)
        {
        }

        internal override void Pagar(decimal monto)
        {
            var total = Descuento.Aplicar(monto);

            // Procesar...
        }
    }
}
