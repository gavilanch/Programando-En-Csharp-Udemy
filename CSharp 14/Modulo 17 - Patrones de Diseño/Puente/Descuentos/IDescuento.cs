using System;
using System.Collections.Generic;
using System.Text;

namespace Puente.Descuentos
{
    internal interface IDescuento
    {
        decimal Aplicar(decimal monto);
    }
}
