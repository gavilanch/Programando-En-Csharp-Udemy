// See https://aka.ms/new-console-template for more information

using Flyweight.Naturaleza;

var factoria = new FactoriaArboles();
var bosque = new Bosque(factoria);

var rnd = new Random();

var tiposArboles = new (string especie, string texturaId, string color)[]
{
    ("Caoba Dominicana", "caoba_dom_hd", "#2E7D32"),
    ("Guayacán", "guayacan_ld", "#6D4C41"),
    ("Roble Caribeño", "roble_carib_4k", "#8D6E63")
};

const int total = 10_000;

for (int i = 0; i < total; i++)
{
    var tipoArbol = tiposArboles[rnd.Next(tiposArboles.Length)];
    int x = rnd.Next(0, 10_000);
    int y = rnd.Next(0, 10_000);
    float altura = 8f + (float)rnd.NextDouble() * 7f;
    float rotacion = (float)rnd.NextDouble() * 360f;

    bosque.PlantarArbol(x, y, altura, rotacion, tipoArbol.especie, tipoArbol.texturaId, tipoArbol.color);
}

Console.WriteLine($"Árboles plantados: {bosque.Conteo}");
Console.WriteLine($"Tipos únicos (flyweights en cache): {factoria.Conteo}");
bosque.Dibujar();

