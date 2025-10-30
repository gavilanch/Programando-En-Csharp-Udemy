using MetodoDeFactoria.Reportes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.ExportadoresDeReportes
{
    internal class ExportadorPdf: ExportadorReporte
    {
        protected override IReporte CrearReporte() => new ReportePdf();
    }
}
