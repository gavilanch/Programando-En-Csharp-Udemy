using System;
using System.Collections.Generic;
using System.Text;

namespace Puente.Descuentos
{
    internal class DescuentoViernesNegro : IDescuento
    {
        public decimal Aplicar(decimal monto) => monto * 0.7m;
    }
}
