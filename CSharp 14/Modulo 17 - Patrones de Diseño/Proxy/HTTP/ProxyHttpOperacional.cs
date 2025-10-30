using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.HTTP
{
    internal class ProxyHttpOperacional: IServicioHttp
    {
        private readonly IServicioHttp _servicioHttp;
        private readonly List<string> _dominiosPermitidos = ["miapi.com"];

        public ProxyHttpOperacional(IServicioHttp servicioHttp)
        {
            _servicioHttp = servicioHttp;
        }

        public Task<string> Get(string url)
        {
            Console.WriteLine("ProxyHttpOperacional: Validando URL");
            ValidarUrl(url);
            return _servicioHttp.Get(url);
        }

        private void ValidarUrl(string url)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri))
                throw new ArgumentException("URL inválida.", nameof(url));
            if (!_dominiosPermitidos.Contains(uri.Host))
                throw new InvalidOperationException($"Dominio no permitido: {uri.Host}");

        }
    }
}
