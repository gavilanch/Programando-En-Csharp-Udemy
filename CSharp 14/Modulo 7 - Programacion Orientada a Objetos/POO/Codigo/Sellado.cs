using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class Sellado
    {
        internal sealed class NoPuedeSerDerivada
        {
        }

        // Error: No se puede heredar de una clase sellada
        //class Derivada: NoPuedeSerDerivada
        //{

        //}

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

            public sealed override void SonarClaxon()
            {
                Console.WriteLine("BIP BIP");
            }
        }

        internal class SonataGris : Carro
        {
            // Error: No se puede sobrescribir un método sellado
            //public override void SonarClaxon()
            //{
            //    base.SonarClaxon();
            //}
        }
    }
}
