using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class Objeto
    {
        // Nota: He abreviado el código de las clases para concentrarnos en lo
        // relevante de este video.
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
        }

        internal class Carro : Vehículo
        {
            public Carro(string marca) : base(marca)
            {
            }
            
            public override string ToString()
            {
                return "Carro con marca " + Marca;
            }
        }

        public void CodigoDelCurso()
        {
            var carro = new Carro("Toyota");
            var carroString = carro.ToString();
            Console.WriteLine("Carro ToString: " + carroString);

            AceptoCualquierParametro(carro);

            AceptoCualquierParametro("Felipe");

            AceptoCualquierParametro(42);

            AceptoCualquierParametro(new Camión());

            AceptoCualquierParametro(DateTime.Now);

            void AceptoCualquierParametro(object objeto)
            {

            }
        }
    }
}
