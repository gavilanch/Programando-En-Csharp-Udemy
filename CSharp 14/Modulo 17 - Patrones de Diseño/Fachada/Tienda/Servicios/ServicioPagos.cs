using Fachada.Tienda.Abstracciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Servicios
{
    public class ServicioPagos : IServicioPagos
    {
        public Task<bool> Cobrar(int clienteId, decimal monto)
        {
            var aprobado = monto > 0m;
            return Task.FromResult(aprobado);
        }
    }

}
