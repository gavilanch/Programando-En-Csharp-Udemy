using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos.Codigo
{
    internal class Indices
    {
        public void CodigoDelCurso()
        {
            var vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

            var segundaVocal = vocales[1]; // e

            var ultimaVocal = vocales[^1]; // u

            Index penultimo = ^2;

            var penultimaVocal = vocales[penultimo]; // o

            Console.WriteLine(penultimaVocal);
        }
    }
}
