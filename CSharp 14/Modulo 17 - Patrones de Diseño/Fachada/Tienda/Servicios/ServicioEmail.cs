using Fachada.Tienda.Abstracciones;
using Fachada.Tienda.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Servicios
{
    public class ServicioEmail : IServicioEmail
    {
        private readonly IServicioClientes _servicioClientes;

        public ServicioEmail(IServicioClientes servicioClientes)
        {
            _servicioClientes = servicioClientes;
        }

        public async Task EnviarFactura(int clienteId, Factura factura)
        {
            var email = await _servicioClientes.ObtenerEmail(clienteId);
            Console.WriteLine($"Factura enviada");
        }
    }

}
