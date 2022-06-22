using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones.Codigo
{
    internal class UsandoYieldConBuclesInfinitos
    {
        public void CodigoDelCurso()
        {
            IEnumerable<int> conElValor2 = Sumar2(2);

            foreach (var valor in conElValor2)
            {
                Console.WriteLine(valor);
            }

            IEnumerable<int> Sumar2(int valor)
            {
                yield return valor;

                for (; ; )
                {
                    valor += 2;
                    yield return valor;
                }
            }
        }
    }
}
