// See https://aka.ms/new-console-template for more information

using Prototipo.Documentos;

var configPagina = new ConfigPagina { MargenSuperior = 3 };
var documento = new Documento() { Autor = "Felipe", Titulo = "Mi trabajo", ConfigPagina = configPagina };

var documentoNuevo = documento.Clonar();

documentoNuevo.Autor = "Claudia";

Console.WriteLine($"Autor del documento original: {documento.Autor}");
Console.WriteLine($"Autor del documento clonado: {documentoNuevo.Autor}");


documentoNuevo.ConfigPagina.MargenSuperior = 5;
Console.WriteLine($"Margen superior del documento original: {documento.ConfigPagina.MargenSuperior}");
Console.WriteLine($"Margen superior del documento clonado: {documentoNuevo.ConfigPagina.MargenSuperior}");
