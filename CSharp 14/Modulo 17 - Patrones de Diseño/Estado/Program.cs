// See https://aka.ms/new-console-template for more information

// Camino feliz
using Estado.Modelos;

Console.WriteLine("-- Documento 1 --");

var doc1 = new Documento("Mi curso", "Contenido del curso de programación.");
doc1.Editar("Contenido versión 1");
doc1.EnviarRevision();
doc1.Aprobar();
doc1.Publicar();

// Error por reenviar sin corregir
Console.WriteLine();
Console.WriteLine("-- Documento 2 --");

var doc2 = new Documento("Mi segundo curso", "Contenido confuso");

doc2.EnviarRevision();
doc2.Rechazar();

try
{
    doc2.EnviarRevision();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

doc2.Editar("Contenido más claro");
doc2.Aprobar();
doc2.Publicar();

