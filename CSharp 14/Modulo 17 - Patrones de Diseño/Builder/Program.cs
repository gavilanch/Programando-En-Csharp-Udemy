// See https://aka.ms/new-console-template for more information

using Builder;
using Builder.Reportes.Builders;
using Builder.Reportes.Comunes;


var reporteContenido = new ReporteContenido(
    Titulo: "Auditoría",
    Autor: "Felipe Gavilán",
    Portada: true,
    TablaContenido: true,
    Secciones: new List<(string, string)> {
        ("Resumen", "Hallazgos clave..."),
        ("Controles", "Detalle de controles..."),
        ("Anexos", "Evidencias...")
    });

var director = new DirectorDeReportes();

ReporteBuilder reporteBuilderMarkdown = new ReporteMarkdownBuilder();
ReporteBuilder reporteBuilderHtml = new ReporteHtmlBuilder();

var reporteMd = director.Construir(reporteBuilderMarkdown, reporteContenido);
var reporteHtml = director.Construir(reporteBuilderHtml, reporteContenido);

//Console.WriteLine("--Reporte markdown--");
//Console.WriteLine(reporteMd.RepresentacionFinal);
//Console.WriteLine("----");

//Console.WriteLine("--Reporte HTML--");
//Console.WriteLine(reporteHtml.RepresentacionFinal);

var reporte2 = reporteBuilderMarkdown.Iniciar()
                                .ConPortada()
                                .ConTablaContenido()
                                .ConAutor("Claudia")
                                .ConTitulo("Mi nuevo reporte")
                                .AgregarSeccion("Seccion 1", "Contenido 1")
                                .AgregarSeccion("Seccion 2", "Contenido 2")
                                .Build();

Console.WriteLine(reporte2);

