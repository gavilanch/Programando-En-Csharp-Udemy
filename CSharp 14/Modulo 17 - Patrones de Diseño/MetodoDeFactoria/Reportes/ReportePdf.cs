using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.Reportes
{
    public class ReportePdf : IReporte
    {
        public string Generar(string contenido)
        {
            return $"[PDF] Reporte en PDF con contenido: {contenido}";
        }
    }
}
