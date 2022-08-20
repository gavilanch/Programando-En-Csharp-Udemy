using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal enum Acciones
    {
        EscribirTXT = 1,
        [Esconder]
        EscribirXML = 2,
        [Esconder(añoInicio: 2023, mesInicio: 8, díaInicio: 18, añoFin: 2023, mesFin: 9, díaFin: 28)]
        EscribirJSON = 3
    }
}
