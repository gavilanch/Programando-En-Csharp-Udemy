using Fachada.Tienda.Abstracciones;
using Fachada.Tienda.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Servicios
{
    public class ServicioCarrito : IServicioCarrito
    {
        public Task<Carrito> ObtenerCarrito(int clienteId)
        {
            var carrito = new Carrito(
                clienteId,
                new List<ItemCarrito>
                {
                    new(new Producto(1, "Libro C#", 25m), 1),
                    new(new Producto(2, "Mouse inalámbrico", 15m), 2)
                }
            );

            return Task.FromResult(carrito);
        }
    }

}
