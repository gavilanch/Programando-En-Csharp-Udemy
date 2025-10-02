using System;
using System.Collections.Generic;
using System.Text;

namespace Clases.Codigo
{
    internal class FieldEjemplo
    {
        public void CodigoDelCurso()
        {
            var carro = new Carro();

            carro.Marca = "Honda";

            Console.WriteLine($"La marca del carro es {carro.Marca}");
            Console.WriteLine($"El nombre comercial del carro es {carro.NombreComercial}");
        }

        internal class Carro
        {
            internal string Marca
            {
                get { return field.ToUpper(); }
                set { field = value; }
            }

            internal int Año { get; set; } = 1990;

            internal int Velocidad { get; private set; } = 20;
            internal string NombreComercial => $"{Marca} ({Año})";
        }
    }
}
