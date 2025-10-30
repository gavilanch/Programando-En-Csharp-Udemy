using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador.HTTP
{
    internal interface IServicioHttp
    {
        Task<string> Obtener(string url);
    }
}
