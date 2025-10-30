using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.HTTP
{
    internal interface IServicioHttp
    {
        Task<string> Get(string url);
    }
}
