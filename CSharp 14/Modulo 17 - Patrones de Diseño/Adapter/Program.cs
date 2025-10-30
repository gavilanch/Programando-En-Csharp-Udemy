// See https://aka.ms/new-console-template for more information

using Adaptador.Correos;

var enviadorCorreos = new AdaptadorEnviadorCorreosB(new EnviadorCorreosB());

await ReseteoContraseña(enviadorCorreos);
await CrearUsuario(enviadorCorreos);

async Task ReseteoContraseña(IEnviadorCorreos enviadorCorreos)
{
    // hace cosas...
    await enviadorCorreos.EnviarCorreo(string.Empty, string.Empty, string.Empty);
    // hace más cosas
}

async Task CrearUsuario(IEnviadorCorreos enviadorCorreos)
{
    // hace cosas...
    await enviadorCorreos.EnviarCorreo(string.Empty, string.Empty, string.Empty);
    // hace más cosas
}
