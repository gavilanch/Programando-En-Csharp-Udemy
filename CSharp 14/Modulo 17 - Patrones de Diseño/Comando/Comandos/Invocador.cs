using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Comandos
{
    public class Invocador
    {
        private readonly Stack<IComando> _deshacerStack = new();
        private readonly Stack<IComando> _rehacerStack = new();

        public void Ejecutar(IComando comando)
        {
            comando.Ejecutar();
            _deshacerStack.Push(comando);
            _rehacerStack.Clear();
        }

        public bool Deshacer()
        {
            if (_deshacerStack.Count == 0)
            {
                return false;
            }

            var comando = _deshacerStack.Pop();
            comando.Deshacer();
            _rehacerStack.Push(comando);
            return true;
        }

        public bool Rehacer()
        {
            if (_rehacerStack.Count == 0)
            {
                return false;
            }

            var comando = _rehacerStack.Pop();
            comando.Ejecutar();
            _deshacerStack.Push(comando);
            return true;
        }

    }
}
