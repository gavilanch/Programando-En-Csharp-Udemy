using System;
using System.Collections.Generic;
using System.Text;

namespace Estado.Modelos
{
    public interface IEstadoDocumento
    {
        EstadoDocumento EstadoDocumento { get; }
        void Editar(string nuevoContenido) => LanzarExcepcion("editar");
        void EnviarRevision() => LanzarExcepcion("enviar a revisión");
        void Aprobar() => LanzarExcepcion("aprobar");
        void Rechazar() => LanzarExcepcion("rechazar");
        void Publicar() => LanzarExcepcion("publicar");

        private void LanzarExcepcion(string operacion) =>
    throw new Exception($"No se puede {operacion} cuando el documento está en estado '{EstadoDocumento}'");


    }

}
