using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal class Persona
    {
        public Persona()
        {

        }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public string? Nombre { get; set; }
        [Range(minimum: 18, maximum: 130)]
        public int Edad { get; set; }
        [Range(minimum: 1, maximum: 5)]
        public int OtroNumero { get; set; }
    }

}
