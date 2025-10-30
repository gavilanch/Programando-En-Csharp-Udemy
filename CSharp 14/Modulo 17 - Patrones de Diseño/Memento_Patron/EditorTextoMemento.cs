using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_Patron
{
    public class EditorTextoMemento(string estado)
    {
        public string Estado { get; } = estado;
    }
}
