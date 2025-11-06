using Estado.Modelos.EstadosDocumento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estado.Modelos
{
    public class Documento
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public IEstadoDocumento EstadoDocumento { get; private set; }

        public Documento(string titulo, string contenido)
        {
            Titulo = titulo;
            Contenido = contenido;
            EstadoDocumento = new EstadoBorrador(this);
        }

        public void CambiarEstado(IEstadoDocumento nuevoEstado) => EstadoDocumento = nuevoEstado;

        public void Editar(string nuevoContenido)
        {
            Console.WriteLine("Editando el documento");
            EstadoDocumento.Editar(nuevoContenido);
            Console.WriteLine("Documento editado");

        }

        public void EnviarRevision()
        {
            Console.WriteLine("Enviando a revisión");
            EstadoDocumento.EnviarRevision();
            Console.WriteLine("Enviado a revisión");
        }

        public void Aprobar()
        {
            Console.WriteLine("Aprobando...");
            EstadoDocumento.Aprobar();
            Console.WriteLine("Documento aprobado");
        }
        public void Rechazar()
        {
            Console.WriteLine("Rechazando...");
            EstadoDocumento.Rechazar();
            Console.WriteLine("Documento rechazado");
        }
        public void Publicar()
        {
            Console.WriteLine("Publicando");
            EstadoDocumento.Publicar();
            Console.WriteLine("Documento publicado");

        }



    }
}
