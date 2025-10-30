using MetodoDeFactoria.Reportes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.ExportadoresDeReportes
{
    internal class ExportadorCsv: ExportadorReporte
    {
        protected override IReporte CrearReporte() => new ReporteCsv();
    }
}
