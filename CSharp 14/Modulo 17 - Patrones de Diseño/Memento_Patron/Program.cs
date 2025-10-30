// See https://aka.ms/new-console-template for more information

using Memento_Patron;

var editor = new EditorTexto();
var historial = new Historial(editor);

while (true)
{
    Console.WriteLine();
    Console.WriteLine("--- Editor de Texto (Memento) ---");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Texto actual: " + editor.Contenido);
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine("[1] Escribir");
    Console.WriteLine("[2] Reemplazar todo");
    Console.WriteLine("[3] Deshacer");
    Console.WriteLine("[4] Rehacer");
    Console.WriteLine("[5] Limpiar");
    Console.WriteLine("[0] Salir");
    Console.Write("Opción: ");
    var operacion = Console.ReadLine();

    switch (operacion)
    {
        case "1": // escribir
            Console.Write("Texto a añadir: ");
            var texto = Console.ReadLine() ?? string.Empty;
            historial.Guardar();
            editor.Escribir(texto);
            break;
        case "2": // reemplazar todo
            Console.Write("Nuevo contenido completo: ");
            var textoCompleto = Console.ReadLine() ?? string.Empty;
            historial.Guardar();
            editor.ReemplazarTodo(textoCompleto);
            break;

        case "3": // deshacer
            historial.Deshacer();
            break;

        case "4": // rehacer
            historial.Rehacer();
            break;

        case "5": // limpiar
            historial.Guardar();
            editor.Limpiar();
            break;

        case "0": // salir
            return;

        default:
            Console.WriteLine("Opción no válida.");
            break;


    }

}