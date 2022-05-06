using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class Verbatim
    {
        public void CodigoDelCurso()
        {

            string carta = @"A quien pueda interesar,

Estimado cliente, debes mucho dinero. El banco dice: ""paganos""

Att: La administración";

            string directorioDelArchivo = @"C:\Mis documentos\Mi carpeta\excel.xlsx";

            Console.WriteLine(carta);
            Console.WriteLine(directorioDelArchivo);
        }
    }
}
