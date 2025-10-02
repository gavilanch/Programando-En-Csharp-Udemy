using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Clases.Codigo
{
    internal class MiembrosRequeridos
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

        public void CodigoDelCurso()
        {
            var miClase = new ClaseConPropiedadesInmutables()
            {
                Propiedad1 = 4,
                Propiedad3 = true
            };
        }
    }
}
