using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Modelos
{
    public record struct PrecioCambio(
       string Simbolo,
       decimal PrecioAnterior,
       decimal PrecioActual,
       DateTime Momento)
    {
        public decimal Variacion => PrecioActual - PrecioAnterior;
        public decimal VariacionPorcentual => PrecioAnterior == 0 ? 0 : (PrecioActual - PrecioAnterior) / PrecioAnterior * 100m;

        public override string ToString()
        {
            var signo = Variacion >= 0 ? "+" : "";
            // Ejemplo: SP500: $6,882.58 +0.39 (+0.06)
            return $"{Simbolo}: {PrecioActual:c} {signo}{Variacion:G} ({signo}{VariacionPorcentual:P})";
        }
    }

}
