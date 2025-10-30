using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Reportes.Builders
{
    internal class ReporteHtmlBuilder : ReporteBuilder
    {
        public override Reporte Build()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html><html><head><meta charset=\"utf-8\"><title>Reporte</title></head><body>");

            if (_portada)
            {
                sb.AppendLine($"<h1>{_titulo}</h1>");
                if (!string.IsNullOrWhiteSpace(_autor))
                    sb.AppendLine($"<p><em>Autor: {System.Net.WebUtility.HtmlEncode(_autor)}</em></p>");
                sb.AppendLine("<hr />");
            }

            if (_tablaDeContenidos && _secciones.Count > 0)
            {
                sb.AppendLine("<h2>Tabla de Contenido</h2><ul>");
                for (int i = 0; i < _secciones.Count; i++)
                    sb.AppendLine($"<li><a href=\"#sec{i + 1}\">{System.Net.WebUtility.HtmlEncode(_secciones[i].Item1)}</a></li>");
                sb.AppendLine("</ul>");
            }

            for (int i = 0; i < _secciones.Count; i++)
            {
                sb.AppendLine($"<h2 id=\"sec{i + 1}\">{System.Net.WebUtility.HtmlEncode(_secciones[i].Item1)}</h2>");
                sb.AppendLine($"<p>{System.Net.WebUtility.HtmlEncode(_secciones[i].Item2)}</p>");
            }

            sb.AppendLine("</body></html>");

            return new Reporte(_titulo, _autor, new List<(string, string)>(_secciones),
                               _portada, _tablaDeContenidos, sb.ToString());
        }

    }
}
