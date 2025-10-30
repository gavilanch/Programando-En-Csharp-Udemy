using Estrategia.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia.Exportadores
{
    internal class ExportadorCSV : IExportador
    {
        public void Exportar(Venta venta)
        {
            Console.WriteLine("Generar reporte en CSV");
        }
    }
}
