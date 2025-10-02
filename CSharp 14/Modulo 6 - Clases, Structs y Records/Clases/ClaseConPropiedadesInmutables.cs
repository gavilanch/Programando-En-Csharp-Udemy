using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class ClaseConPropiedadesInmutables
    {
        [SetsRequiredMembers]
        public ClaseConPropiedadesInmutables()
        {
            Propiedad2 = "Valor por defecto";
        }

        public required int Propiedad1 { get; init; }
        public required string Propiedad2 { get; init; } = "";
        public bool Propiedad3 { get; init; }
    }
}
