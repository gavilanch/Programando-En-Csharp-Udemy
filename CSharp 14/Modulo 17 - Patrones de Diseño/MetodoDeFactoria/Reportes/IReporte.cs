using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoDeFactoria.Reportes
{
    public interface IReporte
    {
        string Generar(string contenido);
    }
}
