using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterador_Patron
{
    public class AdelanteListaDeReproduccionIteradorDotNet : IEnumerator<Cancion>
    {
        private readonly List<Cancion> _canciones;
        private int _indice = -1;

        public AdelanteListaDeReproduccionIteradorDotNet(List<Cancion> canciones) => _canciones = canciones;

        public Cancion Current => _canciones[_indice];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_indice + 1 < _canciones.Count)
            {
                _indice++;
                return true;
            }
            return false;
        }

        public void Reset() => _indice = -1;

        public void Dispose()
        {
        }
    }
}
