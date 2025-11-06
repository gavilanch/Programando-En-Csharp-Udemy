using Observador.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Servicios
{
    public interface IObservadorPrecio
    {
        void Actualizar(PrecioCambio cambio);
    }

}
