using Mediador.Chat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediador.Usuarios
{
    public class UsuarioConcreto : Usuario
    {
        public UsuarioConcreto(IMediadorChat mediador, string nombre)
        : base(mediador, nombre)
        {
        }

        public override void RecibirMensaje(string mensaje, string emisor)
        {
            Console.WriteLine($"{Nombre} recibió mensaje de {emisor}: {mensaje}");
        }

        public override void EnviarMensajeATodos(string mensaje)
        {
            _mediador.EnviarMensajeATodos(mensaje, Nombre);
        }

        public override void EnviarMensaje(string mensaje, string receptor)
        {
            _mediador.EnviarMensaje(mensaje, Nombre, receptor);
        }


    }
}
