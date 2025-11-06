using System;
using System.Collections.Generic;
using System.Text;

namespace Estado.Modelos.EstadosDocumento
{
    public class EstadoRechazado : IEstadoDocumento
    {
        private readonly Documento documento;

        public EstadoDocumento EstadoDocumento => EstadoDocumento.Rechazado;

        public EstadoRechazado(Documento documento)
        {
            this.documento = documento;
        }

        public void Editar(string nuevoContenido)
        {
            documento.Contenido = nuevoContenido;
            documento.CambiarEstado(new EstadoEnRevision(documento));
        }

    }
}
