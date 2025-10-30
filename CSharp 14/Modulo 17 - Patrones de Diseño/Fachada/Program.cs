// See https://aka.ms/new-console-template for more information

using Fachada.Tienda.Abstracciones;
using Fachada.Tienda.Servicios;

IServicioClientes servicioClientes = new ServicioClientes();
IServicioCarrito servicioCarrito = new ServicioCarrito();
IServicioPagos servicioPagos = new ServicioPagos();
IServicioFacturacion servicioFacturacion = new ServicioFacturacion();
IServicioEmail servicioEmail = new ServicioEmail(servicioClientes);

IProcesadorDeCompra procesador = new ProcesadorDeCompras(
        servicioCarrito, servicioPagos, servicioFacturacion, servicioEmail
    );

var clienteId = 1;


var resultado = await procesador.ProcesarCompra(clienteId);