using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador.HTTP
{
    internal abstract class ServicioHttpDecorador: IServicioHttp
    {
        protected readonly IServicioHttp _servicio;

        protected ServicioHttpDecorador(IServicioHttp servicio)
        {
            _servicio = servicio;
        }

        public abstract Task<string> Obtener(string url);
    }
}
