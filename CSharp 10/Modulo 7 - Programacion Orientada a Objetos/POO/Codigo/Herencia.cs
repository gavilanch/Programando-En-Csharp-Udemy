using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class Herencia
    {
        internal class Vehículo
        {
            public string? Marca { get; set; }
            public int AñoCreación { get; set; }
        }

        internal class Carro : Vehículo
        {
            public void EncenderRadio()
            {
                Console.WriteLine("Encendiendo la radio");
            }
        }

        internal class Camión : Vehículo
        {

        }

        internal class Bicicleta : Vehículo
        {

        }

        public void CodigoDelCurso()
        {
            var carro = new Carro();
            carro.Marca = "Toyota";
            carro.EncenderRadio();

            var camión = new Camión();
            camión.Marca = "Mercedes";
            //camión.EncerderRadio();

            var bicicleta = new Bicicleta();
            bicicleta.Marca = "Scott";

            LeerMarca(carro);
            LeerMarca(camión);
            LeerMarca(bicicleta);

            void LeerMarca(Vehículo vehículo)
            {
                //vehículo.EncenderRadio();
                var mensaje = $"Leyendo la marca {vehículo.Marca} del vehículo de tipo {vehículo}";
                Console.WriteLine(mensaje);
            }
        }
    }
}
