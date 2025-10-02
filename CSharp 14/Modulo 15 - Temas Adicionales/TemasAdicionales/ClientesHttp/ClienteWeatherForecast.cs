using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales.ClientesHttp
{
    internal interface IClienteWeatherForecast
    {
        Task<List<WeatherForecast>> Obtener();
    }

    internal class ClienteWeatherForecast : IClienteWeatherForecast
    {
        private readonly HttpClient httpClient;
        private readonly string urlBase = "https://localhost:7169/WeatherForecast/";

        public ClienteWeatherForecast(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<WeatherForecast>> Obtener()
        {
            var respuesta = await httpClient.GetFromJsonAsync<List<WeatherForecast>>(urlBase);

            if (respuesta is null)
            {
                return new List<WeatherForecast>();
            }

            return respuesta;
        }
    }
}
