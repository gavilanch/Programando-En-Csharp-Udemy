// See https://aka.ms/new-console-template for more information

using FactoriaAbstracta.Elementos;

var sistemaOperativo = "macos";

var factoria = FactoriaElementos.CrearFactoria(sistemaOperativo);
var boton = factoria.CrearBoton();
var cuadroDeDialogo = factoria.CrearCuadroDeDialogo();

boton.Presionar();
cuadroDeDialogo.Desplegar();