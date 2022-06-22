using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones
{
    internal class Vehículo
    {

    }

    internal class Carro : Vehículo
    {
        public Carro(string marca)
        {
            Marca = marca;
        }

        public string Marca { get; }
    }

    internal class Camión: Vehículo
    {

    }
}
