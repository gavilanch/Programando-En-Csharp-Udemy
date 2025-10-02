using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class Delegados
    {
        public void CodigoDelCurso()
        {
            Action action;
            Func<int> func;
            Predicate<int> predicado;

            bool TryParse2(string valor, out int resultado)
            {
                return int.TryParse(valor, out resultado);
            }

            //Func<string, out int, bool> tryParseFunc = TryParse2;

            TryParseDelegado miTryParse = TryParse2;

            int cantidad;

            if (miTryParse("12", out cantidad))
            {
                Console.WriteLine(cantidad);
            }

            void Procesar(TryParseDelegado miTryParse)
            {

            }
        }

        delegate bool TryParseDelegado(string valor, out int resultado);
    }
}
