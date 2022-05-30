using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class ClonandoRecords
    {
        public void CodigoDelCurso()
        {
            var empresa1 = new Empresa("Udemy", 2010);

            var empresa2 = empresa1 with { AñoFundación = 2015 };

            Console.WriteLine("Empresa 1: " + empresa1);
            Console.WriteLine("Empresa 2: " + empresa2);
        }
    }
}
