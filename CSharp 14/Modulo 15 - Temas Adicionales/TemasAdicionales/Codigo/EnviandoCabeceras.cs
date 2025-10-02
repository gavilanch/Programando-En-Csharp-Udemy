using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales.Codigo
{
    internal class EnviandoCabeceras
    {
        public async Task CodigoDelCurso()
        {
            var httpClient = new HttpClient();
            var url = "https://localhost:7169/WeatherForecast/mayusculas";

            // Ejemplo 1: Una petición sin mandar la cabecera personalizada

            Console.WriteLine("Ejemplo 1:");
            Console.WriteLine(await httpClient.GetStringAsync(url));

            // Ejemplo 2: Enviando una cabecera personalizada 'una vez'

            using (var peticiónHTTP = new HttpRequestMessage(HttpMethod.Get, url))
            {
                peticiónHTTP.Headers.Add("valorPersonalizado", "Soy Claudia");
                var respuesta = await httpClient.SendAsync(peticiónHTTP);
                Console.WriteLine("Ejemplo 2:");
                Console.WriteLine(await respuesta.Content.ReadAsStringAsync());
            }

            // Ejemplo 3: Mandando la cabecera siempre
            Console.WriteLine("Ejemplo 3:");

            httpClient.DefaultRequestHeaders.Add("valorPersonalizado", "Soy Roberto");

            Console.WriteLine(await httpClient.GetStringAsync(url));

            Console.WriteLine(await httpClient.GetStringAsync(url));

            httpClient.DefaultRequestHeaders.Clear();

            Console.WriteLine("Borramos las cabeceras por defecto");

            Console.WriteLine(await httpClient.GetStringAsync(url));
        }
    }
}
