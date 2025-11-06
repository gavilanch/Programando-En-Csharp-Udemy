using System;
using System.Collections.Generic;
using System.Text;

namespace Estado.Modelos.EstadosDocumento
{
    public class EstadoEnRevision : IEstadoDocumento
    {
        private readonly Documento documento;

        public EstadoDocumento EstadoDocumento => EstadoDocumento.En_Revision;

        public EstadoEnRevision(Documento documento)
        {
            this.documento = documento;
        }

        public void Aprobar() => documento.CambiarEstado(new EstadoAprobado(documento));
        public void Rechazar() => documento.CambiarEstado(new EstadoRechazado(documento));
    }
}
