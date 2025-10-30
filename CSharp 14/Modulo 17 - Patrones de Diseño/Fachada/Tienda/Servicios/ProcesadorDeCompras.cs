using Fachada.Tienda.Abstracciones;
using Fachada.Tienda.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fachada.Tienda.Servicios
{
    internal class ProcesadorDeCompras : IProcesadorDeCompra
    {
        private readonly IServicioCarrito _carrito;
        private readonly IServicioPagos _pagos;
        private readonly IServicioFacturacion _facturacion;
        private readonly IServicioEmail _email;

        public ProcesadorDeCompras(
            IServicioCarrito carrito,
            IServicioPagos pagos,
            IServicioFacturacion facturacion,
            IServicioEmail email)
        {
            _carrito = carrito;
            _pagos = pagos;
            _facturacion = facturacion;
            _email = email;
        }


        public async Task<ResultadoCompra> ProcesarCompra(int clienteId)
        {
            // 1) Obtener carrito
            var carrito = await _carrito.ObtenerCarrito(clienteId);

            if (carrito.Items.Count == 0)
            {
                return new ResultadoCompra(false, "El carrito está vacío.");
            }

            // 2) Calcular total
            var total = carrito.Items.Sum(i => i.Producto.Precio * i.Cantidad);

            // 3) Cobrar
            var cobrado = await _pagos.Cobrar(clienteId, total);
            if (!cobrado)
            {
                return new ResultadoCompra(false, "No se pudo procesar el pago.");
            }

            // 4) Generar factura
            var factura = await _facturacion.GenerarFactura(clienteId, total);

            // 5) Enviar factura por email
            await _email.EnviarFactura(clienteId, factura);

            return new ResultadoCompra(
                        Exito: true,
                        Mensaje: "Compra procesada correctamente.",
                        NumeroFactura: factura.Numero,
                        Total: total
                    );
        }
    }
}
