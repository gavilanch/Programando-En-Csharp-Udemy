// See https://aka.ms/new-console-template for more information

using Proxy.HTTP;

IServicioHttp real = new ServicioHttpReal();
IServicioHttp operacional = new ProxyHttpOperacional(real);

Console.WriteLine("--Ejemplo 1--");
Console.WriteLine();

var url = "https://miapi.com/personas";
await operacional.Get(url);

Console.WriteLine();
Console.WriteLine("--Ejemplo 2--");
Console.WriteLine();

var url2 = "https://undominiodiferente.com/personas";
await operacional.Get(url2);
