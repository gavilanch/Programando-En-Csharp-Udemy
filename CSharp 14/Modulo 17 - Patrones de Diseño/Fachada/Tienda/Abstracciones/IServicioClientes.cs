using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Abstracciones
{
    public interface IServicioClientes
    {
        Task<string> ObtenerEmail(int clienteId);
    }
}
