using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.HTTP
{
    internal class ServicioHttpReal: IServicioHttp
    {
        public Task<string> Get(string url)
        {
            Console.WriteLine($"ServicioHttpReal: GET ejecutado para: {url}");
            return Task.FromResult($"Contenido simulado desde {url}");
        }
    }
}
