using MetodoDeFactoria.Reportes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.ExportadoresDeReportes
{
    public abstract class ExportadorReporte
    {
        protected abstract IReporte CrearReporte();

        public string Exportar(string contenido)
        {
            var reporte = CrearReporte();
            // Aquí podemos colocar código común 
            return reporte.Generar(contenido);
        }
    }
}
