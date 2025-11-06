using Observador.Servicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Modelos
{
    public class PrecioSimbolo: ISujetoPrecio
    {
        private readonly List<IObservadorPrecio> _observadores = new();
        public string Simbolo { get; }
        public decimal PrecioActual { get; private set; }

        public PrecioSimbolo(string simbolo, decimal precioInicial = 0m)
        {
            Simbolo = simbolo;
            PrecioActual = precioInicial;
        }

        public void Suscribir(IObservadorPrecio observador)
        {
            _observadores.Add(observador);
        }

        public void Desuscribir(IObservadorPrecio observador)
        {
            _observadores.Remove(observador);
        }

        private void Notificar(PrecioCambio cambio)
        {
            foreach (var observador in _observadores)
            {
                observador.Actualizar(cambio);
            }
        }

        public void SetearPrecio(decimal nuevoPrecio)
        {
            if (nuevoPrecio == PrecioActual) return;

            var cambio = new PrecioCambio(
                                Simbolo,
                                PrecioAnterior: PrecioActual,
                                PrecioActual: nuevoPrecio,
                                Momento: DateTime.UtcNow
                            );

            PrecioActual = nuevoPrecio;
            Notificar(cambio);
        }
    }
}
