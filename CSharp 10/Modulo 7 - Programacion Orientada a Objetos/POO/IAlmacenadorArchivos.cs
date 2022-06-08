using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal interface IAlmacenadorArchivos
    {
        string Guardar(string archivo);
        void Borrar(string urlArchivo);
        string Editar(string urlArchivoAnterior, string archivo)
        {
            Borrar(urlArchivoAnterior);
            return Guardar(archivo);
        }
    }
}
