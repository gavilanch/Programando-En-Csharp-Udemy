using Fachada.Tienda.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Abstracciones
{
    internal interface IServicioEmail
    {
        Task EnviarFactura(int clienteId, Factura factura);
    }
}
