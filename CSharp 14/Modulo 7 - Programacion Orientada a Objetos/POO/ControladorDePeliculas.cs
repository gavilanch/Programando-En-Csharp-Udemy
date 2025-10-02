using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class ControladorDePeliculas
    {
        private readonly IAlmacenadorArchivos almacenadorArchivos;

        public ControladorDePeliculas(IAlmacenadorArchivos almacenadorArchivos)
        {
            this.almacenadorArchivos = almacenadorArchivos;
        }

        public void GuardarPoster(string poster)
        {
            // Más código
            almacenadorArchivos.Guardar(poster);
            // Más código
        }

        public void BorrarPoster(string urlPoster)
        {
            // Más código
            almacenadorArchivos.Borrar(urlPoster);
            // Más código
        }
    }
}
