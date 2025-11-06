using System;
using System.Collections.Generic;
using System.Text;

namespace Iterador_Patron
{
    public class AdelanteListaDeReproduccionIterador : IIterador<Cancion>
    {
        private readonly List<Cancion> _canciones;
        private int _indice = -1;

        public AdelanteListaDeReproduccionIterador(List<Cancion> canciones) => _canciones = canciones;

        public Cancion Actual => _canciones[_indice];

        public bool MoverHaciaSiguiente()
        {
            if (_indice + 1 < _canciones.Count)
            {
                _indice++;
                return true;
            }
            return false;
        }

        public void Resetear() => _indice = -1;

    }
}
