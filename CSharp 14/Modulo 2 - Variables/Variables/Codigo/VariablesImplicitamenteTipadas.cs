#pragma warning disable CS0219 // Variable is assigned but its value is never used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class VariablesImplicitamenteTipadas
    {
        public void CodigoDelCurso()
        {

            var edadDeFelipe = 999; // camelCase
            var apellido = "Gavilán";
            var hoy = DateTime.Now;
            var float1 = 1.9f;

            // No podemos usar var si no le asignamos un valor a la variable inmediatamente
            int edad;

            edad = 8;
        }
    }
}

#pragma warning restore CS0219 // Variable is assigned but its value is never used