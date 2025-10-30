// See https://aka.ms/new-console-template for more information

using Compuesto.Tienda;

var telefono = new Producto("Teléfono X", 450m);
var audifonos = new Producto("Audífonos Pro", 80m);
var cableUsb = new Producto("Cable USB-C", 12.50m);
var laptop = new Producto("Laptop Ultrabook", 1200m);
var mouse = new Producto("Mouse Inalámbrico", 25m);
var impresora = new Producto("Impresora Multifuncional", 180m);
var resma = new Producto("Resma Papel A4 (x500)", 6.75m);


var comboGamer = new Combo("Combo Gamer", descuento: 0.9m);
comboGamer.Agregar(laptop);
comboGamer.Agregar(mouse);
comboGamer.Agregar(audifonos);

var kitOficina = new Combo("Kit de Oficina");
kitOficina.Agregar(resma);
kitOficina.Agregar(cableUsb);

var carrito = new Carrito();
carrito.Agregar(telefono);
carrito.Agregar(comboGamer);
carrito.Agregar(kitOficina);
carrito.ImprimirResumen();

Console.WriteLine();
Console.WriteLine("-- Removemos un combo --");
Console.WriteLine();

carrito.Remover(comboGamer);
carrito.ImprimirResumen();