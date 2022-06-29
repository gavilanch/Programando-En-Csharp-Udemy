using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloLINQ.Codigo
{
    internal class DistinctYDistinctBy
    {
        public void CodigoDelCurso()
        {
            var personas = new List<Persona>() {
new Persona { Nombre = "Eduardo", EmpresaId = 1, },
new Persona { Nombre = "Nidia",  EmpresaId = 1 },
new Persona { Nombre = "Eduardo"},
new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
};

            int[] numeros = { 1, 2, 3, 1, 1, 6 };

            var numerosSinRepeticion = numeros.Distinct();

            var personasSinRepeticion = personas.DistinctBy(p => p.Nombre);
        }
    }
}
