using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class SkipYTake
    {
        public void CodigoDelCurso()
        {
            var numeros = Enumerable.Range(1, 100);

            var primeros10Numeros = numeros.Take(10).ToList();
            var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();

            var últimos10Números = numeros.TakeLast(10).ToList();
            var penúltimoLoteDe10 = numeros.SkipLast(10).TakeLast(10).ToList();
        }
    }
}
