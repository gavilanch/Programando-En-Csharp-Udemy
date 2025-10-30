using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador.HTTP
{
    internal class ServicioHttpConCache : ServicioHttpDecorador
    {
        private readonly Dictionary<string, string> _cache = new();

        public ServicioHttpConCache(IServicioHttp servicio) : base(servicio)
        {
        }

        public override async Task<string> Obtener(string url)
        {
            if (_cache.TryGetValue(url, out var respuesta))
            {
                Console.WriteLine($"[CACHE] Respuesta obtenida desde caché para {url}");
                return respuesta;
            }

            respuesta = await _servicio.Obtener(url);
            _cache[url] = respuesta;

            Console.WriteLine($"[CACHE] Guardando en caché: {url}");
            return respuesta;

        }
    }
}
