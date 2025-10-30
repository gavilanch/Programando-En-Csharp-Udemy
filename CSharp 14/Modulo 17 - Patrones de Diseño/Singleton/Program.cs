// See https://aka.ms/new-console-template for more information

using Singleton;

// Error
//var logger = new Logger();

//var logger = Logger.Instancia;
//var logger2 = Logger.Instancia;

//Console.WriteLine($"¿Son la misma instancia? {logger == logger2}");

Parallel.For(0, 1000, _ =>
{
    var logger = Logger.Instancia;
});