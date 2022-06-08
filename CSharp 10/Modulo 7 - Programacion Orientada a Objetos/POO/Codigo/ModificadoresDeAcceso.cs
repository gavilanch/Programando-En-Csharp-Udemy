using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace POO.Codigo
{
    internal class ModificadoresDeAcceso
    {
        public void CodigoDelCurso()
        {
            var clasePublicaDePrueba = new ClasePublicaDePrueba();
            clasePublicaDePrueba.PropiedadPublica = 1;
            clasePublicaDePrueba.MetodoPublico();
            //clasePublicaDePrueba.PropiedadProtectedInternal = 7;
            //clasePublicaDePrueba.MetodoPrivado();
            //clasePublicaDePrueba.PropiedadInterna = 5;
        }
    }
}
