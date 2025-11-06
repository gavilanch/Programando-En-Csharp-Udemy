// See https://aka.ms/new-console-template for more information
using Interprete.Expresiones;
using Interprete.Parseadores;

var operacionMatematica = "1+2*3";

//var expresionMatematica = new SumaExpresion(
//        izquierda: new NumeroExpresion(1),
//        derecha: new MultiplicacionExpresion(
//                izquierda: new NumeroExpresion(2),
//                derecha: new NumeroExpresion(3)));

var parseador = new Parseador(operacionMatematica);
var expresionMatematica = parseador.Parsear();

var resultado = expresionMatematica.Interpretar();
Console.WriteLine($"El resultado de {operacionMatematica} es {resultado}");
