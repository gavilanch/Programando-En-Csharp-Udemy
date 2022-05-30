using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class Campos
    {
        internal class Carro
        {
            // Por convención, los campos empiezan con guión bajo
            internal string _marca;
            internal int _año;
        }

        public void CodigoDelCurso()
        {
            var carro1 = new Carro();
            carro1._marca = "Toyota";
            carro1._año = 2003;

            ModificarMarca(carro1);
            Console.WriteLine(carro1._marca); // Toyota2

            var carro2 = new Carro();
            carro2._marca = "Hyundai";
            carro2._año = 2013;

            Console.WriteLine(carro2._marca); // Hyundai

            // Es un tipo de referencia
            carro2 = null;

            void ModificarMarca(Carro carro)
            {
                carro._marca += "2";
            }
        }
    }
}
