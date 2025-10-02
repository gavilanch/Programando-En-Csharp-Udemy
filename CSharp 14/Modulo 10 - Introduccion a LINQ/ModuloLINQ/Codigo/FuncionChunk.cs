using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class FuncionChunk
    {
        public void CodigoDelCurso()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var resultado = numeros.Chunk(3);
        }
    }
}
