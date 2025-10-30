using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptador.Correos
{
    internal class AdaptadorEnviadorCorreosA(EnviadorCorreosA enviadorCorreosA) : IEnviadorCorreos
    {
        public async Task EnviarCorreo(string a, string titulo, string cuerpo)
        {
            await enviadorCorreosA.EnviarCorreo(a, titulo, cuerpo);
        }
    }
}
