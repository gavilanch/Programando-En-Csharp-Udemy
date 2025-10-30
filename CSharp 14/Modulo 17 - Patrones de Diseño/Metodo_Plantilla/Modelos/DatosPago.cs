using System;
using System.Collections.Generic;
using System.Text;

namespace Metodo_Plantilla.Modelos
{
    public record DatosPago(decimal Monto, string ClienteId, string? Datos);
}
