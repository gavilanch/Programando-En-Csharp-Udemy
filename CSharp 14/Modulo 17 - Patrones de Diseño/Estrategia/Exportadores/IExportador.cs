using Estrategia.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estrategia.Exportadores
{
    public interface IExportador
    {
        void Exportar(Venta venta);
    }
}
