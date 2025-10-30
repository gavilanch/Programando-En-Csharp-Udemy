using Estrategia.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia.Exportadores
{
    public class ExportadorXML : IExportador
    {
        public void Exportar(Venta reporte)
        {
            Console.WriteLine("Generar reporte en XML");
        }
    }
}
