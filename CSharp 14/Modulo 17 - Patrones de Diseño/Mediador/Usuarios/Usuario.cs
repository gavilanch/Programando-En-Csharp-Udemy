using Mediador.Chat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediador.Usuarios
{
    public abstract class Usuario
    {
        protected IMediadorChat _mediador;
        public string Nombre { get; }

        protected Usuario(IMediadorChat mediador, string nombre)
        {
            _mediador = mediador;
            Nombre = nombre;
        }

        public abstract void RecibirMensaje(string mensaje, string emisor);
        public abstract void EnviarMensajeATodos(string mensaje);
        public abstract void EnviarMensaje(string mensaje, string receptor);
    }

}
