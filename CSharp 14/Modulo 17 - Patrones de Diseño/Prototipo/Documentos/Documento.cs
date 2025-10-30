using Prototipo.Utilidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo.Documentos
{
    public class Documento : IPrototipo<Documento>
    {
        public string Titulo { get; set; } = "";
        public string Autor { get; set; } = "";
        public ConfigPagina ConfigPagina { get; set; } = new();

        public Documento Clonar()
        {
            return new Documento { Titulo = Titulo, Autor = Autor, ConfigPagina = ConfigPagina.Clonar() };
        }
    }

}
