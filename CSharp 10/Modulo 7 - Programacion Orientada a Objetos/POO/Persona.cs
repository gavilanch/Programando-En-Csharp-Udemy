using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal record Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }

    internal record Profesor: PersonaPosicional
    {
        public Profesor(string Nombre, string Apellido) : base(Nombre, Apellido)
        {
        }

        public string[]? AsignaturasQueEnseña { get; set; }
    }

    internal record PersonaPosicional(string Nombre, string Apellido);

    internal record ProfesorPosicional(string Nombre, string Apellido, 
        string[] AsignaturasQueEnseña): PersonaPosicional(Nombre, Apellido);

}

   
