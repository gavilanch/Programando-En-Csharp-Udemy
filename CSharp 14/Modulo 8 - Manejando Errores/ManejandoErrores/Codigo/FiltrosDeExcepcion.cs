using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores.Codigo
{
    internal class FiltrosDeExcepcion
    {
        internal class ExcepcionPersonalizada : Exception
        {
            public ExcepcionPersonalizada(TipoError tipoError) : base("Esta es una excepción personalizada")
            {
                TipoError = tipoError;
            }

            public ExcepcionPersonalizada(TipoError tipoError, string? mensaje) : base(mensaje)
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

        public void CodigoDelCurso()
        {
            try
            {
                throw new ExcepcionPersonalizada(TipoError.RecursoNoEncontrado,
                    "Este es un mensaje nuevo de excepción");
            }
            catch (ExcepcionPersonalizada ex) when (ex.TipoError == TipoError.ErrorDelCliente)
            {
                Console.WriteLine("Error del cliente");
            }
            catch (ExcepcionPersonalizada ex) when (ex.TipoError == TipoError.ErrorDelServidor)
            {
                Console.WriteLine("Error del servidor");
            }
            catch (ExcepcionPersonalizada ex) when (ex.TipoError == TipoError.RecursoNoEncontrado)
            {
                Console.WriteLine("Recurso no encontrado");
            }

            Console.WriteLine("Fin del programa");
        }
    }
}
