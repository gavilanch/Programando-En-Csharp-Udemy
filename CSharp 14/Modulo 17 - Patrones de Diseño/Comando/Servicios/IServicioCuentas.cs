using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Servicios
{
    public interface IServicioCuentas
    {
        void Depositar(string titular, decimal monto);
        void Retirar(string titular, decimal monto);
    }

}
