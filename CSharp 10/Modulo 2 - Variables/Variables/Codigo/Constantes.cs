#pragma warning disable CS0219 // Variable is assigned but its value is never used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class Constantes
    {
        public void CodigoDelCurso()
        {
            var cantidad1 = 1;
            cantidad1 = 2;

            const int miConstante = 7;

            const double FactorConversionKilometrosPorHoraAMetrosPorSegundo = 3.6;

            var velocidadKPH = 100;
            var velocidadMPS = velocidadKPH / FactorConversionKilometrosPorHoraAMetrosPorSegundo;
        }
    }
}
#pragma warning restore CS0219 // Variable is assigned but its value is never used