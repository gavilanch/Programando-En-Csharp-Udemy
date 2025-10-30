using MetodoDeFactoria.Reportes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.ExportadoresDeReportes
{
    internal class ExportadorExcel: ExportadorReporte
    {
        protected override IReporte CrearReporte() => new ReporteExcel();
    }
}
