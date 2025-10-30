using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador.HTTP
{
    internal class ServicioHttp: IServicioHttp
    {
        public async Task<string> Obtener(string url)
        {
            Console.WriteLine("[SERVICIO HTTP]: Ejecutando la petición...");
            await Task.Delay(500);
            return $"Respuesta de {url} a las {DateTime.Now:T}";
        }
    }
}
