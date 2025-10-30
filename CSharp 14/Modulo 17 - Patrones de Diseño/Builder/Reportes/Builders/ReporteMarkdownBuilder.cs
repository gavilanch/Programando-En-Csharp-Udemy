using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Reportes.Builders
{
    internal class ReporteMarkdownBuilder : ReporteBuilder
    {
        public override Reporte Build()
        {
            var sb = new StringBuilder();

            if (_portada)
            {
                sb.AppendLine($"# {_titulo}");
                if (!string.IsNullOrWhiteSpace(_autor))
                    sb.AppendLine($"> Autor: **{_autor}**");
                sb.AppendLine();
                sb.AppendLine("---");
            }

            if (_tablaDeContenidos && _secciones.Count > 0)
            {
                sb.AppendLine("## Tabla de Contenido");
                for (int i = 0; i < _secciones.Count; i++)
                    sb.AppendLine($"- [{_secciones[i].Item1}](#sec{i + 1})");
                sb.AppendLine();
            }

            for (int i = 0; i < _secciones.Count; i++)
            {
                sb.AppendLine($"## <a name=\"sec{i + 1}\"></a>{_secciones[i].Item1}");
                sb.AppendLine(_secciones[i].Item2);
                sb.AppendLine();
            }

            return new Reporte(_titulo, _autor, new List<(string, string)>(_secciones),
                               _portada, _tablaDeContenidos, sb.ToString());

        }
    }
}
