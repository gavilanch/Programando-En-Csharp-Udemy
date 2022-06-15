using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores
{
    internal class ExcepcionPersonalizada: Exception
    {
        public ExcepcionPersonalizada(TipoError tipoError) :base("Esta es una excepción personalizada")
        {
            TipoError = tipoError;
        }

        public ExcepcionPersonalizada(TipoError tipoError, string? mensaje): base(mensaje)
        {
            TipoError = tipoError;
        }

        public TipoError TipoError { get; }
    }

    internal enum TipoError
    {
        ErrorDelCliente,
        ErrorDelServidor,
        RecursoNoEncontrado
    }
}
