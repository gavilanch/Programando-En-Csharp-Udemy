using Comando.Servicios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Comandos
{
    public class ComandoRetirar(IServicioCuentas servicio, string titular, decimal monto) : IComando
    {
        public void Deshacer()
        {
            servicio.Depositar(titular, monto);
        }

        public void Ejecutar()
        {
            servicio.Retirar(titular, monto);
        }
    }
}
