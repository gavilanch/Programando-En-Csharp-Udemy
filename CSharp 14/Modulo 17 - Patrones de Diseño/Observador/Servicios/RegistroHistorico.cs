using Observador.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Servicios
{
    public class RegistroHistorico : IObservadorPrecio
    {
        private readonly List<PrecioCambio> _historial = new();
        public IReadOnlyList<PrecioCambio> Historial => _historial;
        public void Actualizar(PrecioCambio cambio) => _historial.Add(cambio);
    }
}
