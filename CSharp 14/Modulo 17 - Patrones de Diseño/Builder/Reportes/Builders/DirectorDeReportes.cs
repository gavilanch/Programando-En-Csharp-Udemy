using Builder.Reportes.Comunes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Reportes.Builders
{
    internal class DirectorDeReportes
    {
        public Reporte Construir(ReporteBuilder builder, ReporteContenido reporteContenido)
        {
            builder.Iniciar()
                   .ConTitulo(reporteContenido.Titulo)
                   .ConTablaContenido(reporteContenido.TablaContenido);

            if (!string.IsNullOrWhiteSpace(reporteContenido.Autor))
                builder.ConAutor(reporteContenido.Autor!);

            if (reporteContenido.Portada)
                builder.ConPortada();

            foreach (var (titulo, contenido) in reporteContenido.Secciones)
                builder.AgregarSeccion(titulo, contenido);

            return builder.Build();
        }
    }
}
