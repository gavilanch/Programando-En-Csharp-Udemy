using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores.Codigo
{
    internal class VideoExcepcionPersonalizada
    {

        internal class ExcepcionPersonalizada : Exception
        {
            public ExcepcionPersonalizada() : base("Esta es una excepción personalizada")
            {

            }

            public ExcepcionPersonalizada(string? mensaje) : base(mensaje)
            {

            }
        }

        public void CodigoDelCurso()
        {
            try
            {
                throw new ExcepcionPersonalizada("Este es un mensaje nuevo de excepción");
            }
            catch (ExcepcionPersonalizada)
            {
                Console.WriteLine("Yo puedo manejar nuestra excepción");
            }
        }
    }
}
