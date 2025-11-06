using System;
using System.Collections.Generic;
using System.Text;

namespace Estado.Modelos.EstadosDocumento
{
    public class EstadoAprobado : IEstadoDocumento
    {
        private readonly Documento documento;

        public EstadoDocumento EstadoDocumento => EstadoDocumento.Aprobado;

        public EstadoAprobado(Documento documento)
        {
            this.documento = documento;
        }

        public void Publicar() => Console.WriteLine("Subiendo el documento a la nube...");

    }
}
