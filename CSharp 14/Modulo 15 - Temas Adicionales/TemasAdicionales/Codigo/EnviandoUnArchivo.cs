using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemasAdicionales.ClientesHttp;

namespace TemasAdicionales.Codigo
{
    internal class EnviandoUnArchivo
    {
        public async Task CodigoDelCurso()
        {
            var serviceCollection = new ServiceCollection();
            Configurar(serviceCollection);
            var servicios = serviceCollection.BuildServiceProvider();
            var httpClientFactory = servicios.GetRequiredService<IHttpClientFactory>();
            var clienteWF = httpClientFactory.CreateClient("weatherforecast");

            var rutaArchivo = @"../../../Ejemplo.txt";
            var nombreArchivo = Path.GetFileName(rutaArchivo);

            using (var contenido = new MultipartFormDataContent())
            {
                using (var fs = File.OpenRead(rutaArchivo))
                {
                    contenido.Add(new StreamContent(fs), "archivo", nombreArchivo);
                    var respuesta = await clienteWF.PostAsync("posteoArchivo", contenido);
                    respuesta.EnsureSuccessStatusCode();
                }
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
