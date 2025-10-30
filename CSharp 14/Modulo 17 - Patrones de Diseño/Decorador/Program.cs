// See https://aka.ms/new-console-template for more information

using Decorador.HTTP;


//IServicioHttp servicio =
//       new ServicioHttpConMetrica(
//           new ServicioHttpConCache(
//                new ServicioHttp()
//               ));

string[] decoradores = ["cache", "metrica"];

var servicio = FactoriaServicioHttpPorNombre.Crear(decoradores);

Console.WriteLine("Primera llamada (debe ir al servicio real):");
var resultado1 = await servicio.Obtener("https://felipe-gavilan.com");
Console.WriteLine(resultado1);
Console.WriteLine();

Console.WriteLine("Segunda llamada (debe venir del caché):");
var resultado2 = await servicio.Obtener("https://felipe-gavilan.com");
Console.WriteLine(resultado2);
