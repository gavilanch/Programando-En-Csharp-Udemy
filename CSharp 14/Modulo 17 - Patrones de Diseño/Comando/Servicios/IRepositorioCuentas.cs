using Comando.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Servicios
{
    public interface IRepositorioCuentas
    {
        Cuenta? ObtenerPorTitular(string titular);
        void Guardar(Cuenta cuenta);
    }

}
