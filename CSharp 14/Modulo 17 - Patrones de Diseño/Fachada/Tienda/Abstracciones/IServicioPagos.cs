using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Abstracciones
{
    internal interface IServicioPagos
    {
        Task<bool> Cobrar(int clienteId, decimal monto);
    }
}
