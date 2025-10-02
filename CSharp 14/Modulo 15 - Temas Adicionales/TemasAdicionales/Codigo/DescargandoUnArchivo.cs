using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemasAdicionales.ClientesHttp;

namespace TemasAdicionales.Codigo
{
    internal class DescargandoUnArchivo
    {
        public async Task CodigoDelCurso()
        {
            var serviceCollection = new ServiceCollection();
            Configurar(serviceCollection);
            var servicios = serviceCollection.BuildServiceProvider();
            var httpClientFactory = servicios.GetRequiredService<IHttpClientFactory>();
            var clienteHttp = httpClientFactory.CreateClient();

            var rutaCarpeta = "../../../";

            var urlArchivo = @"https://localhost:7169/carpeta/c8aa5fd3-0004-4850-a3be-62b4e16ef32f.txt";

            var stream = await clienteHttp.GetStreamAsync(urlArchivo);

            var nombreArchivo = Path.GetFileName(urlArchivo);

            using (var fs = File.Create(Path.Combine(rutaCarpeta, nombreArchivo)))
            {
                await stream.CopyToAsync(fs);
            }
        }

        static void Configurar(ServiceCollection servicios)
        {
            // Ejemplo 1: uso básico
            //servicios.AddHttpClient();

            // Ejemplo 2: Clientes nombrados
            servicios.AddHttpClient("tareas", opciones =>
            {
                opciones.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/");
            });

            servicios.AddHttpClient("weatherforecast", opciones =>
            {
                opciones.BaseAddress = new Uri("https://localhost:7169/WeatherForecast/");
                opciones.DefaultRequestHeaders.Add("valorPersonalizado", "Soy un cliente nombrado");
            });

            // Ejemplo 3: Clientes tipados
            servicios.AddHttpClient<IClienteWeatherForecast, ClienteWeatherForecast>();
        }
    }
}
