using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales.Codigo
{
    internal class ParsearErrores
    {
        public async Task CodigoDelCurso()
        {
            var httpClient = new HttpClient();
            var url = "https://localhost:7169/WeatherForecast";

            var wf = new WeatherForecast()
            {
                Date = DateTime.Now,
                TemperatureC = 90,
            };

            var wfSerializado = JsonConvert.SerializeObject(wf);
            var stringContent = new StringContent(wfSerializado, Encoding.UTF8, "application/json");
            var respuesta = await httpClient.PostAsync(url, stringContent);

            if (respuesta.IsSuccessStatusCode)
            {
                Console.WriteLine("Todo bien");
            }
            else if (respuesta.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var cuerpo = await respuesta.Content.ReadAsStringAsync();
                var camposConErrores = Utilidades.ExtraerErroresDelWebAPI(cuerpo);

                foreach (var campoConErrores in camposConErrores)
                {
                    Console.WriteLine($"- {campoConErrores.Key}");

                    foreach (var error in campoConErrores.Value)
                    {
                        Console.WriteLine($"    {error}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Otro tipo de situación");
            }


        }
    }
}
