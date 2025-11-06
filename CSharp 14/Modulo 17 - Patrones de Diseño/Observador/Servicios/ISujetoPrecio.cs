using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Servicios
{
    public interface ISujetoPrecio
    {
        void Suscribir(IObservadorPrecio observador);
        void Desuscribir(IObservadorPrecio observador);
    }
}
