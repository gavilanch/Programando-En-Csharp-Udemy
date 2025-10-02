using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemasAdicionales.ClientesHttp;

namespace TemasAdicionales.Codigo
{
    internal class UsandoElHttpClientFactory
    {
        public async Task CodigoDelCurso()
        {
            // Esto es mala práctica
            //using (var httpClient = new HttpClient())
            //{

            //}

            var url = "https://localhost:7169/WeatherForecast/mayusculas";
            var serviceCollection = new ServiceCollection();
            Configurar(serviceCollection);
            var servicios = serviceCollection.BuildServiceProvider();
            var httpClientFactory = servicios.GetRequiredService<IHttpClientFactory>();

            // Ejemplo 1: uso básico
            var httpClient = httpClientFactory.CreateClient();
            var respuesta = await httpClient.GetAsync(url);
            Console.WriteLine("Ejemplo 1 exitoso: " + respuesta.IsSuccessStatusCode);

            // Ejemplo 2: Clientes nombrados
            var clienteTareas = httpClientFactory.CreateClient("tareas");
            // Envía la petición al BaseAddress
            var respuestaTareas = await clienteTareas.GetAsync("");
            Console.WriteLine("Ejemplo 2 (tareas) exitoso: " + respuestaTareas.IsSuccessStatusCode);

            var clienteWF = httpClientFactory.CreateClient("weatherforecast");
            var respuestaWF = await clienteWF.GetAsync("mayusculas"); // weatherforecast/mayusculas
            Console.WriteLine("Ejemplo 2 (wf) exitoso: " + respuestaWF.IsSuccessStatusCode);

            // Ejemplo 3: Cliente tipado
            var clienteWF2 = servicios.GetRequiredService<IClienteWeatherForecast>();
            var listado = await clienteWF2.Obtener();
            Console.WriteLine("cantidad de wfs: " + listado.Count);
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
