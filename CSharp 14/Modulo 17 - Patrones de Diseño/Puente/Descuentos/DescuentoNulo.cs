using System;
using System.Collections.Generic;
using System.Text;

namespace Puente.Descuentos
{
    internal class DescuentoNulo : IDescuento
    {
        public decimal Aplicar(decimal monto) => monto;
    }
}
