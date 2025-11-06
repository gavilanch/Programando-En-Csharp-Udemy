using Observador.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observador.Servicios
{
    public class AlertaVariacion : IObservadorPrecio
    {
        private readonly decimal _umbralPorcentual;

        public AlertaVariacion(decimal umbralPct)
        {
            _umbralPorcentual = Math.Abs(umbralPct / 100);
        }

        public void Actualizar(PrecioCambio cambio)
        {
            if (Math.Abs(cambio.VariacionPorcentual) >= _umbralPorcentual)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"ADVERTENCIA: EL PRECIO DE {cambio.Simbolo} HA CAMBIADO EN UN {cambio.VariacionPorcentual:p}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

    }
}
