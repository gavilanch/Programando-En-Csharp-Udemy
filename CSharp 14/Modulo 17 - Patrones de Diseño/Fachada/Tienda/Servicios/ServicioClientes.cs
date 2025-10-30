using Fachada.Tienda.Abstracciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Servicios
{
    public class ServicioClientes : IServicioClientes
    {
        public Task<string> ObtenerEmail(int clienteId)
        {
            return Task.FromResult($"cliente{clienteId}@mail.com");
        }
    }
}
