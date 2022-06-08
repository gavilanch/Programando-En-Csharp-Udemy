using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class Abstracto
    {
        internal abstract class Vehículo
        {
            public string? Marca { get; set; }
            public int AñoCreación { get; set; }
            public int Velocidad { get; private set; }
            public abstract int VelocidadMaxima { get; }

            public virtual void DarReversa()
            {
                Console.WriteLine("Dando reversa - Implementación por defecto");
            }

            public abstract void SonarClaxon();

            internal void Acelerar(int incremento = 1)
            {
                if (Velocidad >= VelocidadMaxima)
                {
                    Console.WriteLine("La velocidad máxima ya ha sido alcanzada");
                    return;
                }
                else if (Velocidad + incremento > VelocidadMaxima)
                {
                    incremento = VelocidadMaxima - Velocidad;
                }

                Velocidad += incremento;
            }
        }

        internal class Carro : Vehículo
        {
            public override int VelocidadMaxima => 80;

            public void EncenderRadio()
            {
                Console.WriteLine("Encendiendo la radio");
            }

            public override void SonarClaxon()
            {
                Console.WriteLine("BIP BIP");
            }
        }

        internal class Camión : Vehículo
        {
            public override int VelocidadMaxima => 70;

            public override void DarReversa()
            {
                base.DarReversa();
                Console.WriteLine("BEEP! BEEP! BEEP!");
            }

            public override void SonarClaxon()
            {
                Console.WriteLine("PON POOOON");

            }
        }

        internal class Bicicleta : Vehículo
        {
            public override int VelocidadMaxima => 20;

            public override void SonarClaxon()
            {
                Console.WriteLine("Tirín");
            }
        }

        public void CodigoDelCurso()
        {
            var carro = new Carro();
            carro.Acelerar(200);
            Console.WriteLine("La velocidad del carro es: " + carro.Velocidad);

            var bicicleta = new Bicicleta();
            bicicleta.Acelerar(200);
            Console.WriteLine("La velocidad del bicicleta es: " + bicicleta.Velocidad);
        }
    }
}
