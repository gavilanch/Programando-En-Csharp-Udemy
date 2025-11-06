// See https://aka.ms/new-console-template for more information

using Visitante.Modelos;
using Visitante.Servicios;

var empleados = new List<Empleado>
{
    new Gerente("Claudia", salarioBase: 180_000m, años: 7, puntuacion: 0.88, proyectosLiderados: 9, personasACargo: 24),
    new Desarrollador("Felipe", salarioBase:120_000m, años: 3, puntuacion: 0.77, historiasCompletadas: 85, bugsResueltos: 140),
    new Vendedor("Roberto",salarioBase: 90_000m, años: 6, puntuacion: 0.92, ventasTrimestrales: 2_400_000m, clientesNuevos: 14)
};

var calculadoraBonos = new CalculadoraBonosVisitante();
var reporteDesempeño = new ReporteDesempeñoVisitante();


foreach (var empleado in empleados)
{
    empleado.Aceptar(calculadoraBonos);
    empleado.Aceptar(reporteDesempeño);
}

var bonos = calculadoraBonos.Bonos;
var reporte = reporteDesempeño.Reportes;


Console.WriteLine("-- BONOS --");
foreach (var bono in bonos)
{
    Console.WriteLine($"{bono.Key}: {bono.Value:c}");
}

Console.WriteLine();
Console.WriteLine("-- DESEMPEÑO --");

foreach (var linea in reporte)
{
    Console.WriteLine(linea);
    Console.WriteLine();
}
