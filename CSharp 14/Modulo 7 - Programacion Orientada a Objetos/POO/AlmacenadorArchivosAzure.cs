using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class AlmacenadorArchivosAzure: IAlmacenadorArchivos
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
}
