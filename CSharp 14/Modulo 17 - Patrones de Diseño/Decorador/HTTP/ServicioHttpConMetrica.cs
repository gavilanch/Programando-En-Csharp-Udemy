using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Decorador.HTTP
{
    internal class ServicioHttpConMetrica : ServicioHttpDecorador
    {
        public ServicioHttpConMetrica(IServicioHttp servicio) : base(servicio)
        {
        }

        public override async Task<string> Obtener(string url)
        {
            var stopwatch = Stopwatch.StartNew();

            var respuesta = await _servicio.Obtener(url);

            stopwatch.Stop();

            Console.WriteLine($"[MÉTRICA] Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");

            return respuesta;
        }
    }
}
