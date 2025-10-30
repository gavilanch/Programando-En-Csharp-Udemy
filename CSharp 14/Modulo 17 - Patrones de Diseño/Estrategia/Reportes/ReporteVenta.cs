using Estrategia.Exportadores;
using Estrategia.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia.Reportes
{
    public class ReporteVenta
    {
        private readonly IExportador exportador;

        public ReporteVenta(IExportador exportador)
        {
            this.exportador = exportador;
        }

        public void SetearExportador(IExportador exportador)
        {
            //this.exportador = exportador;
        }

        public void GenerarReporte(int ventaId)
        {
            var venta = new Venta(ventaId, "Felipe", 99m);
            exportador.Exportar(venta);
        }
    }
}
