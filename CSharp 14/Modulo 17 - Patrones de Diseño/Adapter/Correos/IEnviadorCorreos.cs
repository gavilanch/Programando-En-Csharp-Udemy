using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptador.Correos
{
    public interface IEnviadorCorreos
    {
        Task EnviarCorreo(string a, string titulo, string cuerpo);
    }
}
