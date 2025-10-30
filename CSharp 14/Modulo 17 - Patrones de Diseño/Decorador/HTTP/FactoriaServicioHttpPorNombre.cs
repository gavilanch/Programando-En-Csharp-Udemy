using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador.HTTP
{
    internal static class FactoriaServicioHttpPorNombre
    {
        private static readonly Dictionary<string, Func<IServicioHttp, IServicioHttp>>
            _decoradores = new(StringComparer.OrdinalIgnoreCase)
            {
                ["cache"] = servicio => new ServicioHttpConCache(servicio),
                ["metrica"] = servicio => new ServicioHttpConMetrica(servicio)
            };

        public static IServicioHttp Crear(IEnumerable<string> seleccion)
        {
            IServicioHttp servicio = new ServicioHttp();

            foreach (var nombre in seleccion)
            {
                if (_decoradores.TryGetValue(nombre, out var decorador))
                {
                    servicio = decorador(servicio);
                }
                else
                {
                    throw new ArgumentException($"Decorador desconocido: {nombre}");
                }
            }

            return servicio;
        }
    }
}
