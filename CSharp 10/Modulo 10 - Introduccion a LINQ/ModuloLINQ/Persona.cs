using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ
{
    internal class Persona
    {
        public string Nombre { get; set; } = null!;
        public int Edad { get; set; }
        public bool Soltero { get; set; }
        public DateTime FechaIngresoALaEmpresa { get; set; }
        public List<string> Telefonos = new List<string>();
        public int EmpresaId { get; set; }
    }
}
