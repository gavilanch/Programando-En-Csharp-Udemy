// See https://aka.ms/new-console-template for more information

using Cadena_De_Responsabilidad.Modelos;
using Cadena_De_Responsabilidad.Validaciones;

var felipe = new RegistroUsuario("Felipe", "felipe@ejemplo.com", "123456");
var claudia = new RegistroUsuario("Claudia", "claudia@ejemplo.com", "123456");

var validador = new CamposRequeridosValidador();

validador.SetearSiguiente(new EmailFormatoValidador())
    .SetearSiguiente(new EmailYaExisteValidador());

Registrar(claudia, validador);

void Registrar(RegistroUsuario registroUsuario, IValidador<RegistroUsuario> validador)
{
    var resultado = validador.RealizarValidaciones(registroUsuario);

    Console.WriteLine($"¿El modelo es válido? {resultado.EsExitoso}");

    if (!resultado.EsExitoso)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(resultado.Error);
        Console.ForegroundColor = ConsoleColor.Gray;
        return;
    }
}
