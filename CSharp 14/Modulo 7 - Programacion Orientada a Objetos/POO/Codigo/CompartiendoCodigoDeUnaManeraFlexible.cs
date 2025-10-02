using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class CompartiendoCodigoDeUnaManeraFlexible
    {
        internal interface IAlmacenadorArchivos
        {
            string Guardar(string archivo);
        }

        internal class ControladorDePeliculas
        {
            public void GuardarPoster(string poster, IAlmacenadorArchivos almacenadorArchivos)
            {
                // Más código
                almacenadorArchivos.Guardar(poster);
                // Más código
            }
        }

        internal class AlmacenadorArchivosAWS : IAlmacenadorArchivos
        {
            public string Guardar(string archivo)
            {
                Console.WriteLine("Guardando el archivo en AWS");
                return "URL del archivo en AWS";
            }
        }

        internal class AlmacenadorArchivosAzure : IAlmacenadorArchivos
        {
            public string Guardar(string archivo)
            {
                Console.WriteLine("Guardando el archivo en Azure");
                return "URL del archivo";
            }
        }

        public void CodigoDelCurso()
        {
            var controladorDePeliculas = new ControladorDePeliculas();

            var almacenadorArchivosAzure = new AlmacenadorArchivosAzure();
            var almacenadorArchivosAWS = new AlmacenadorArchivosAWS();

            controladorDePeliculas.GuardarPoster("poster.jpg", almacenadorArchivosAWS);
        }
    }
}
