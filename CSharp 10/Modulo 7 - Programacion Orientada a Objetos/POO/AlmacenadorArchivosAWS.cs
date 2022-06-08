using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
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

        public string Editar(string urlArchivoAnterior, string archivo)
        {
            Console.WriteLine("Nueva implementación de editar");
            return "";
        }
    }
}
