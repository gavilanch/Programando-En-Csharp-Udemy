using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class PropiedadesInmutablesConInit
    {
        internal class ClaseConPropiedadesInmutables
        {
            public int Propiedad1 { get; init; }
            public string Propiedad2 { get; init; } = "";
            public bool Propiedad3 { get; init; }
        }

        public void CodigoDelCurso()
        {
            var clase = new ClaseConPropiedadesInmutables()
            {
                Propiedad1 = 42,
                Propiedad3 = true,
                Propiedad2 = "Felipe"
            };

            //clase.Propiedad2 = "Roberto";
        }
    }
}
