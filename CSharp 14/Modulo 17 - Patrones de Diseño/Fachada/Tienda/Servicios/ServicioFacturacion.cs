using Fachada.Tienda.Abstracciones;
using Fachada.Tienda.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Servicios
{
    public class ServicioFacturacion : IServicioFacturacion
    {
        public Task<Factura> GenerarFactura(int clienteId, decimal total)
        {
            var factura = new Factura(
                Numero: $"FAC-{DateTime.UtcNow:yyyyMMddHHmmss}",
                ClienteId: clienteId,
                Total: total,
                Fecha: DateTime.UtcNow
            );

            return Task.FromResult(factura);
        }
    }

}
