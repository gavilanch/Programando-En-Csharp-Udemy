using Metodo_Plantilla.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodo_Plantilla.Pagos
{
    public class PagoConTarjeta : PagoBase
    {
        protected override void ProcesarCobro(DatosPago pago)
        {
            Console.WriteLine($"Cobrando {pago.Monto:C} a tarjeta...");
        }

        protected override void EnviarNotificacion(DatosPago pago)
        {
            Console.WriteLine("Enviando correo al titular de la tarjeta...");
        }

    }
}
