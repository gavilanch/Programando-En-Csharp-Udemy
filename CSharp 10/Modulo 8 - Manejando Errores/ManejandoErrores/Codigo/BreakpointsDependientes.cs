using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores.Codigo
{
    internal class BreakpointsDependientes
    {
        public void CodigoDelCurso()
        {
            MetodoB();
            MetodoA();
            MetodoB();

            void MetodoA()
            {

            }

            void MetodoB()
            {

            }

        }
    }
}
