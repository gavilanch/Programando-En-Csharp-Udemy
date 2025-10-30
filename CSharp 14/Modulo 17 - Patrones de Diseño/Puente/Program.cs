// See https://aka.ms/new-console-template for more information


using Puente.Descuentos;
using Puente.Ventas;

Venta ventaInmediataSinDescuento = new VentaInmediata(new DescuentoNulo());
ventaInmediataSinDescuento.Pagar(100);

Venta ventaConPreautorizacionConDescuentoViernesNegro = new VentaConPreautorizacion(new DescuentoViernesNegro());