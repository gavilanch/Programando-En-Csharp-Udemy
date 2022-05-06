using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class Advertencias
    {
        public void CodigoDelCurso()
        {
            // Esto me permite remover advertencias.
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            var cantidad1 = 1;
            cantidad1 = 2;

            const int miConstante = 7;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            
            // El código fuera de la sección anterior muestra las advertencias
            var cantidad2 = 7;
        }
    }
}
