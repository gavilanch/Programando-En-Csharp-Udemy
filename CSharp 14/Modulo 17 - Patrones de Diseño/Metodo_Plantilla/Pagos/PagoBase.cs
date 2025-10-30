using Metodo_Plantilla.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodo_Plantilla.Pagos
{
    public abstract class PagoBase
    {
        public void ProcesarPago(DatosPago pago)
        {
            AntesDeProcesar(pago);
            ValidarPago(pago);

            ProcesarCobro(pago);

            if (DebeEnviarNotificacion(pago))
            {
                EnviarNotificacion(pago);
            }

            DespuesDeProcesar(pago);
        }

        protected virtual void AntesDeProcesar(DatosPago pago) { }

        protected virtual void DespuesDeProcesar(DatosPago pago)
    => Console.WriteLine("DespuesDeProcesar: Limpieza de recursos.");


        protected virtual void ValidarPago(DatosPago pago)
        {
            if (pago.Monto <= 0) throw new InvalidOperationException("Monto inválido.");

            if (string.IsNullOrWhiteSpace(pago.Datos)) throw new InvalidOperationException("Faltan los datos del medio de pago.");
        }

        protected abstract void ProcesarCobro(DatosPago pago);

        protected virtual bool DebeEnviarNotificacion(DatosPago pago) => true;

        protected virtual void EnviarNotificacion(DatosPago pago)
    => Console.WriteLine("EnviarNotificacion: Notificación simple: pago procesado.");

    }
}
