using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.Reportes
{
    public class ReporteCsv : IReporte
    {
        public string Generar(string contenido)
        {
            return $"[CSV] Reporte en CSV con contenido: {contenido}";
        }
    }
}
