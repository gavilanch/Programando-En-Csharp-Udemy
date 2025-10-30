using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_Patron
{
    public class Historial(EditorTexto editor)
    {
        private readonly Stack<EditorTextoMemento> _deshacer = new();
        private readonly Stack<EditorTextoMemento> _rehacer = new();

        public void Guardar()
        {
            _deshacer.Push(editor.CrearMemento());
            _rehacer.Clear();
        }

        public void Deshacer()
        {
            if (_deshacer.Count == 0)
            {
                Console.WriteLine("Nada que deshacer.");
                return;
            }

            _rehacer.Push(editor.CrearMemento());
            var memento = _deshacer.Pop();
            editor.Restaurar(memento);
        }

        public void Rehacer()
        {
            if (_rehacer.Count == 0)
            {
                Console.WriteLine("Nada que rehacer.");
                return;
            }

            _deshacer.Push(editor.CrearMemento());
            var memento = _rehacer.Pop();
            editor.Restaurar(memento);
        }

    }
}
