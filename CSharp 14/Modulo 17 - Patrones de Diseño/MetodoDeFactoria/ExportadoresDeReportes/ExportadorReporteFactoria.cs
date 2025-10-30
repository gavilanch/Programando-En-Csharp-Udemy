using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.ExportadoresDeReportes
{
    internal static class ExportadorReporteFactoria
    {
        public static ExportadorReporte CrearExportador(string tipoReporte)
        {
            return tipoReporte switch
            {
                "pdf" => new ExportadorPdf(),
                "excel" => new ExportadorExcel(),
                "csv" => new ExportadorCsv(),
                _ => throw new NotImplementedException("tipo de reporte inexistente")

            };
        }
    }
}
