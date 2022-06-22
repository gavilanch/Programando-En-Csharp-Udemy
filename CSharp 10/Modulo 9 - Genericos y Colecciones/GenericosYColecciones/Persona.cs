using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones
{
    internal class Persona : IComparable<Persona>
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public int CompareTo(Persona? otro)
        {
            if (otro is null)
            {
                throw new ArgumentNullException(nameof(otro));
            }

            // Explicación: Si el valor es < 0, entonces la persona actual va primero
            // si el valor es > 0, entonces la persona actual va de segundo
            // si el valor es = 0, entonces llevan el mismo orden

            return this.Edad - otro.Edad;

        }
    }
}
