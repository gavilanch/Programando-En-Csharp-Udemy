using Mediador.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediador.Chat
{
    public interface IMediadorChat
    {
        void Registrar(Usuario usuario);
        void EnviarMensajeATodos(string mensaje, string nombreEmisor);
        void EnviarMensaje(string mensaje, string nombreEmisor, string nombreReceptor);
    }
}
