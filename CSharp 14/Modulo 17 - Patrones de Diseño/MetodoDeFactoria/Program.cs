// See https://aka.ms/new-console-template for more information

using MetodoDeFactoria;
using MetodoDeFactoria.ExportadoresDeReportes;

var tipoReporte = "excel";
var contenido = "Este es el contenido del reporte";

var reporte = ExportadorReporteFactoria.CrearExportador(tipoReporte);
var reporteGenerado = reporte.Exportar(contenido);

Console.WriteLine(reporteGenerado);
