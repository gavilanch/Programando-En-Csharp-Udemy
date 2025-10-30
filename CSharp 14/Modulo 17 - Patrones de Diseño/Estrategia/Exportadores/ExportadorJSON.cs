using Estrategia.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia.Exportadores
{
    public class ExportadorJSON : IExportador
    {
        public void Exportar(Venta reporte)
        {
            Console.WriteLine("Generar reporte en JSON");
        }
    }
}
