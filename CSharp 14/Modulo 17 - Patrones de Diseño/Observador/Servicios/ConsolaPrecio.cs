using Observador.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Servicios
{
    public class ConsolaPrecio : IObservadorPrecio
    {
        public void Actualizar(PrecioCambio cambio)
        {
            Console.WriteLine(cambio.ToString());
        }
    }

}
