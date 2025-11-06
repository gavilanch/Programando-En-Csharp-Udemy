using System;
using System.Collections.Generic;
using System.Text;

namespace Estado.Modelos.EstadosDocumento
{
    public class EstadoBorrador : IEstadoDocumento
    {
        private readonly Documento documento;

        public EstadoDocumento EstadoDocumento => EstadoDocumento.Borrador;

        public EstadoBorrador(Documento documento)
        {
            this.documento = documento;
        }

        public void Editar(string nuevoContenido) => documento.Contenido = nuevoContenido;

        public void EnviarRevision() => documento.CambiarEstado(new EstadoEnRevision(documento));
    }
}
