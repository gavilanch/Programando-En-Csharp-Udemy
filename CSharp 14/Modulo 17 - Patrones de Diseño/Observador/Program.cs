// See https://aka.ms/new-console-template for more information

using Observador.Modelos;
using Observador.Servicios;
await Task.Delay(3000);
var sp500 = new PrecioSimbolo("SP500", 6000m);

var consolaObservador = new ConsolaPrecio();

var alerta25 = new AlertaVariacion(2.5m);
var registro = new RegistroHistorico();

sp500.Suscribir(consolaObservador);
sp500.Suscribir(alerta25);
sp500.Suscribir(registro);

sp500.SetearPrecio(6000.99m);

await Task.Delay(1000);

sp500.SetearPrecio(6100m);

await Task.Delay(1000);

sp500.SetearPrecio(6099.54m);

await Task.Delay(1000);


Console.WriteLine("--- NOS DESUSCRIBIMOS DE ALERTA25 ---");

sp500.Desuscribir(alerta25);

await Task.Delay(1000);

sp500.SetearPrecio(6000m);

Console.WriteLine($"Cambios registrados: {registro.Historial.Count}");


