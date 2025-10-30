// See https://aka.ms/new-console-template for more information

using Mediador.Chat;
using Mediador.Usuarios;

var chat = new SalaDeChat();

var felipe = new UsuarioConcreto(chat, "Felipe");
var claudia = new UsuarioConcreto(chat, "Claudia");
var roberto = new UsuarioConcreto(chat, "Roberto");

chat.Registrar(felipe);
chat.Registrar(claudia);
chat.Registrar(roberto);

felipe.EnviarMensajeATodos("¡Hola a todos!");
claudia.EnviarMensaje("Hola Felipe, ¿cómo estás?", "Felipe");