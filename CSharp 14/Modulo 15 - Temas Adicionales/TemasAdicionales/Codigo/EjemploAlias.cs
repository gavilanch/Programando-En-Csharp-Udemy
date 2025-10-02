using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Felipe = TemasAdicionales.Ejemplos.Felipe;
using Claudia = TemasAdicionales.Ejemplos.Claudia;

namespace TemasAdicionales.Codigo
{
    internal class EjemploAlias
    {
        public void CodigoDelCurso()
        {
            Console.WriteLine(Felipe.EjemploAlias.Nombre);
            Console.WriteLine(Claudia.EjemploAlias.Nombre);
        }
    }
}
