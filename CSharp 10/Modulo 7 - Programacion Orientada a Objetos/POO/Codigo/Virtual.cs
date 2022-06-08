using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class Virtual
    {

        internal class Vehículo
        {
            public string? Marca { get; set; }
            public int AñoCreación { get; set; }

            public virtual void DarReversa()
            {
                Console.WriteLine("Dando reversa - Implementación por defecto");
            }
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
            public override void DarReversa()
            {
                base.DarReversa();
                Console.WriteLine("BEEP! BEEP! BEEP!");
            }
        }

        internal class Bicicleta : Vehículo
        {

        }

        public void CodigoDelCurso()
        {
            var carro = new Carro();
            var camión = new Camión();
            var bicicleta = new Bicicleta();

            Console.Write("Carro: ");
            carro.DarReversa();
            Console.WriteLine("--");

            Console.Write("Camión: ");
            camión.DarReversa();
            Console.WriteLine("--");

            Console.Write("Bicicleta: ");
            bicicleta.DarReversa();

        }
    }
}
