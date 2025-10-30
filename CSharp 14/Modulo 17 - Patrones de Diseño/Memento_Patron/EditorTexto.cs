using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_Patron
{
    public class EditorTexto
    {
        public string Contenido { get; private set; } = string.Empty;

        public void Escribir(string texto) => Contenido += texto;

        public void ReemplazarTodo(string texto) => Contenido = texto;

        public void Limpiar() => Contenido = string.Empty;

        public EditorTextoMemento CrearMemento() => new(Contenido);

        public void Restaurar(EditorTextoMemento m) => Contenido = m.Estado;
    }

}
