using Metodo_Plantilla.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodo_Plantilla.Pagos
{
    public class PagoConPaypal : PagoBase
    {
        protected override void ValidarPago(DatosPago pago)
        {
            base.ValidarPago(pago);

            if (!pago.Datos!.Contains("@")) throw new InvalidOperationException("Email PayPal inválido.");
        }

        protected override void ProcesarCobro(DatosPago pago)
        {
            Console.WriteLine($"Cobrando {pago.Monto:C} a paypal...");
        }

        protected override bool DebeEnviarNotificacion(DatosPago pago)
        {
            return false;
        }
    }

}
