using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Reportes.Comunes
{
    public record ReporteContenido(
     string Titulo,
     string? Autor,
     bool Portada,
     bool TablaContenido,
     IReadOnlyList<(string Titulo, string Contenido)> Secciones);

}
