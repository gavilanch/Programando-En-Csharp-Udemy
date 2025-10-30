// See https://aka.ms/new-console-template for more information

using Estrategia.Exportadores;
using Estrategia.Reportes;

IExportador exportador = new ExportadorXML();
var reporteVenta = new ReporteVenta(exportador);
reporteVenta.GenerarReporte(ventaId: 1);