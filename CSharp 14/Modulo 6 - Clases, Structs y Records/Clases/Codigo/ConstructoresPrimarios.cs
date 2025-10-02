using System;
using System.Collections.Generic;
using System.Text;

namespace Clases.Codigo
{
    internal class ConstructoresPrimarios
    {
        public void CodigoDelCurso()
        {
            var cliente = new Cliente("Felipe", "Gavilán", 999, "Mi calle");
            var cliente2 = new Cliente("Claudia", "Rodríguez", 888);

            Console.WriteLine(cliente.Apellido);
            Console.WriteLine(cliente.EsMayorDeEdad);
        }

        internal class Cliente(string nombre, string apellido, int edad, string direccion)
        {
            public Cliente(string nombre, string apellido, int edad)
                : this(nombre, apellido, edad, string.Empty)
            {

            }


            public string Nombre { get; } = nombre;
            public string Apellido { get; } = apellido;
            //public int Edad { get; } = edad;
            public bool EsMayorDeEdad => edad >= 18;
            public string Direccion { get; } = direccion;
        }
    }
}
