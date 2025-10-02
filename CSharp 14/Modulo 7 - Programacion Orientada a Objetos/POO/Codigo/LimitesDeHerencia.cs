using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class LimitesDeHerencia
    {
        public class Base1
        {
            public int PropiedadBase1 { get; set; }
        }

        public class Base2 : Base1
        {
            public int PropiedadBase2 { get; set; }
        }

        // Error: No se puede heredar de dos clases
        //public class Derivada : Base1, Base2
        //{
        //    void Metodo()
        //    {
        //        PropiedadBase2 = 2;
        //        PropiedadBase1 = 1;
        //    }
        //}

        public class Derivada : Base2
        {
            void Metodo()
            {
                PropiedadBase2 = 2;
                PropiedadBase1 = 1;
            }
        }

        public class SubDerivada : Derivada
        {

        }
    }
}
