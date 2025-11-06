using System;
using System.Collections.Generic;
using System.Text;

namespace Iterador_Patron
{
    public class ReversaListaDeReproduccionIterador : IIterador<Cancion>
    {
        private readonly List<Cancion> _canciones;
        private int _indice;

        public ReversaListaDeReproduccionIterador(List<Cancion> canciones)
        {
            _canciones = canciones;
            _indice = _canciones.Count;
        }

        public Cancion Actual => _canciones[_indice];

        public bool MoverHaciaSiguiente()
        {
            if (_indice - 1 >= 0)
            {
                _indice--;
                return true;
            }
            return false;
        }

        public void Resetear() => _indice = _canciones.Count;
    }
}
