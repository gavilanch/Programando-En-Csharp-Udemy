using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.Reportes
{
    public class ReporteExcel : IReporte
    {
        public string Generar(string contenido)
        {
            return $"[EXCEL] Reporte en Excel con contenido: {contenido}";
        }
    }

}
