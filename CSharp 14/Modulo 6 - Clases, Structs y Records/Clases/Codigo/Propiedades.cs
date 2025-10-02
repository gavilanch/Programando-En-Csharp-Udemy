using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class Propiedades
    {
        internal class Carro
        {
            // Por convención, los campos empiezan con guión bajo
            private string _marca;

            internal string Marca
            {
                get { return _marca.ToUpper(); }
                set { _marca = value; }
            }

            internal int Año { get; set; } = 1990;

            internal int Velocidad { get; private set; } = 20;
            internal string NombreComercial => $"{Marca} ({Año})";
        }

        public void CodigoDelCurso()
        {
            var carro1 = new Carro();
            carro1.Marca = "Toyota";
            carro1.Año = 2003;

            ModificarMarca(carro1);
            //carro1.Velocidad = 25;
            Console.WriteLine($"{carro1.NombreComercial}; velocidad = {carro1.Velocidad}");

            var carro2 = new Carro();
            carro2.Marca = "Hyundai";
            carro2.Año = 2013;

            Console.WriteLine(carro2.Marca);

            // Es un tipo de referencia
            carro2 = null;

            void ModificarMarca(Carro carro)
            {
                carro.Marca += "2";
            }
        }
    }
}
