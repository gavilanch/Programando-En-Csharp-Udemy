using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    internal class Cliente(string nombre, string apellido, int edad, string direccion)
    {
        public Cliente(string nombre, string apellido, int edad)
            :this(nombre, apellido, edad, string.Empty)
        {

        }


        public string Nombre { get; } = nombre;
        public string Apellido { get; } = apellido;
        //public int Edad { get; } = edad;
        public bool EsMayorDeEdad => edad >= 18;
        public string Direccion { get; } = direccion;
    }
}
