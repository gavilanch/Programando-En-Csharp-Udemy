// See https://aka.ms/new-console-template for more information

using Metodo_Plantilla.Modelos;
using Metodo_Plantilla.Pagos;

PagoBase tarjeta = new PagoConTarjeta();
PagoBase paypal = new PagoConPaypal();

Console.WriteLine("Pago con tarjeta");
tarjeta.ProcesarPago(new DatosPago(150m, "cliente1", "4111111111111111"));

Console.WriteLine();

Console.WriteLine("Pago con Paypal");
paypal.ProcesarPago(new DatosPago(49.99m, "cliente2", "felipe@ejemplo.com"));

