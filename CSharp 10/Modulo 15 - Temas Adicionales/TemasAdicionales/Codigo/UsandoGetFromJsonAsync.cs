using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales.Codigo
{
    internal class UsandoGetFromJsonAsync
    {
        public async Task CodigoDelCurso()
        {
            var httpClient = new HttpClient();
            var url = "https://localhost:7169/WeatherForecast";

            var respuestaSerializada = await httpClient.GetFromJsonAsync<List<WeatherForecast>>(url);

            Console.WriteLine(respuestaSerializada!.Count);

        }
    }
}
