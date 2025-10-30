using Comando.Servicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Comandos
{
    public class ComandoDepositar(IServicioCuentas servicio, string titular, decimal monto) : IComando
    {
        public void Deshacer()
        {
            servicio.Retirar(titular, monto);
        }

        public void Ejecutar()
        {
            servicio.Depositar(titular, monto);
        }
    }
}
