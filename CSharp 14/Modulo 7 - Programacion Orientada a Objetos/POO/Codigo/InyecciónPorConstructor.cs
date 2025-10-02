using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class InyecciónPorConstructor
    {
        internal interface IAlmacenadorArchivos
        {
            string Guardar(string archivo);
            void Borrar(string urlArchivo);
        }

        internal class AlmacenadorArchivosAzure : IAlmacenadorArchivos
        {
            public void Borrar(string urlArchivo)
            {
                Console.WriteLine("Borrando el archivo en Azure");
            }

            public string Guardar(string archivo)
            {
                Console.WriteLine("Guardando el archivo en Azure");
                return "URL del archivo";
            }
        }

        internal class AlmacenadorArchivosAWS : IAlmacenadorArchivos
        {
            public void Borrar(string urlArchivo)
            {
                Console.WriteLine("Borrando el archivo en aws");
            }

            public string Guardar(string archivo)
            {
                Console.WriteLine("Guardando el archivo en AWS");
                return "URL del archivo en AWS";
            }
        }

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


        public void CodigoDelCurso()
        {
            var almacenadorArchivosAzure = new AlmacenadorArchivosAzure();
            var almacenadorArchivosAWS = new AlmacenadorArchivosAWS();

            var controladorDePeliculas = new ControladorDePeliculas(almacenadorArchivosAWS);

            controladorDePeliculas.GuardarPoster("poster.jpg");
            controladorDePeliculas.BorrarPoster("poster.jpg");
        }
    }
}
