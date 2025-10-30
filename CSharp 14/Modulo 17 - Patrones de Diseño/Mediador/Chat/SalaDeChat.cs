using Mediador.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediador.Chat
{
    public class SalaDeChat : IMediadorChat
    {
        private readonly List<Usuario> _usuarios = new();

        public void Registrar(Usuario usuario)
        {
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
        }

        public void EnviarMensaje(string mensaje, string nombreEmisor, string nombreReceptor)
        {
            var emisor = _usuarios.FirstOrDefault(u => u.Nombre == nombreEmisor);

            if (emisor is null) return;

            var receptor = _usuarios.FirstOrDefault(u => u.Nombre == nombreReceptor);
            receptor?.RecibirMensaje(mensaje, nombreEmisor);
        }

        public void EnviarMensajeATodos(string mensaje, string nombreEmisor)
        {
            foreach (var usuario in _usuarios.Where(u => u.Nombre != nombreEmisor))
            {
                usuario.RecibirMensaje(mensaje, nombreEmisor);
            }
        }



    }
}
