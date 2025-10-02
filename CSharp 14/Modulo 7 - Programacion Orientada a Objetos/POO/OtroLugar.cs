using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class OtroLugar
    {
        private readonly ControladorDePeliculas controladorDePeliculas;

        public OtroLugar(ControladorDePeliculas controladorDePeliculas)
        {
            this.controladorDePeliculas = controladorDePeliculas;
        }

        public void Procesar()
        {
            controladorDePeliculas.GuardarPoster("un poster.jpg");
        }
    }
}
