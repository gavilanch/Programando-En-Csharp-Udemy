using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Reportes.Builders
{
    internal abstract class ReporteBuilder
    {
        protected string _titulo = "";
        protected string _autor = "";
        protected readonly List<(string, string)> _secciones = new();
        protected bool _portada;
        protected bool _tablaDeContenidos;

        public ReporteBuilder Iniciar()
        {
            _titulo = "";
            _autor = "";
            _secciones.Clear();
            _portada = false;
            _tablaDeContenidos = false;
            return this;
        }

        public ReporteBuilder ConTitulo(string titulo)
        {
            _titulo = titulo;
            return this;
        }

        public ReporteBuilder ConAutor(string autor)
        {
            _autor = autor;
            return this;
        }

        public ReporteBuilder AgregarSeccion(string titulo, string contenido)
        {
            _secciones.Add((titulo, contenido));
            return this;
        }

        public ReporteBuilder ConPortada(bool incluir = true)
        {
            _portada = incluir;
            return this;
        }

        public ReporteBuilder ConTablaContenido(bool incluir = true)
        {
            _tablaDeContenidos = incluir;
            return this;
        }

        public abstract Reporte Build();
    }
}
