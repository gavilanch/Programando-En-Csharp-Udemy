using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Reportes
{
    public class Reporte(string titulo,
        string autor,
        List<(string, string)> secciones,
        bool incluirPortada,
        bool incluirTablaContenido,
        string representacionFinal)
    {
        public string Titulo { get; } = titulo;
        public string Autor { get; } = autor;
        public IReadOnlyList<(string Titulo, string Contenido)> Secciones { get; } = secciones.AsReadOnly();
        public bool IncluirPortada { get; } = incluirPortada;
        public bool IncluirTablaContenido { get; } = incluirTablaContenido;
        public string RepresentacionFinal { get; } = representacionFinal;

        public override string ToString() => RepresentacionFinal;
    }

}
