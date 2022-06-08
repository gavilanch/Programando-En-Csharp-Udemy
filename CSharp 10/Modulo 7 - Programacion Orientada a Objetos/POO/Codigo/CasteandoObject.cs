using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class CasteandoObject
    {
        internal abstract class Vehículo
        {
            public Vehículo()
            {

            }

            public Vehículo(string marca)
            {
                Marca = marca;
            }

            public string? Marca { get; set; }
            
            public virtual void DarReversa()
            {
                Console.WriteLine("Dando reversa - Implementación por defecto");
            }

            public abstract void SonarClaxon();
        }

        internal class Carro : Vehículo
        {
            public Carro(string marca) : base(marca)
            {
            }

            public sealed override void SonarClaxon()
            {
                Console.WriteLine("BIP BIP");
            }
        }

        internal class Camión : Vehículo
        {
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

        public void CodigoDelCurso()
        {
            var carro = new Carro("Toyota");
            var carroString = carro.ToString();
            Console.WriteLine("Carro ToString: " + carroString);

            AceptoCualquierParametro(carro);

            AceptoCualquierParametro(new Camión());

            //AceptoCualquierParametro("Felipe");

            AceptoCualquierParametro(42);

            //AceptoCualquierParametro(DateTime.Now);

            void AceptoCualquierParametro(object objeto)
            {
                Console.WriteLine("--- Inicio del método ---");

                if (objeto is Carro carro)
                {
                    Console.WriteLine("El objeto es un carro");
                    carro.SonarClaxon();
                }
                else if (objeto is Camión camion)
                {
                    Console.WriteLine("El objeto es un camión");
                    camion.DarReversa();
                }
                else if (objeto is int entero)
                {
                    Console.WriteLine("El objeto es un entero: " + entero);
                }
                else
                {
                    Console.WriteLine("El objeto NO es un carro");
                }

                Console.WriteLine("--- Fin del método ---");
            }
        }
    }
}
