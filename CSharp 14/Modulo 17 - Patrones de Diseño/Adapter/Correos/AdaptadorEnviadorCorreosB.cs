using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptador.Correos
{
    internal class AdaptadorEnviadorCorreosB(EnviadorCorreosB enviadorCorreosB) : IEnviadorCorreos
    {
        public async Task EnviarCorreo(string a, string titulo, string cuerpo)
        {
            await enviadorCorreosB.EnviarCorreo2(a, titulo, cuerpo);
        }
    }
}
