using System;
using System.Collections.Generic;
using System.Text;

namespace Iterador_Patron
{
    public class AleatorioListaDeReproduccionIterador : IIterador<Cancion>
    {
        private readonly List<Cancion> _canciones;
        private readonly List<int> _orden;
        private int _posicion = -1;

        public AleatorioListaDeReproduccionIterador(List<Cancion> canciones)
        {
            _canciones = canciones;
            _orden = OrdenarAleatoriamente(_canciones.Count);
        }

        public Cancion Actual => _canciones[_orden[_posicion]];

        public bool MoverHaciaSiguiente()
        {
            if (_posicion + 1 < _orden.Count)
            {
                _posicion++;
                return true;
            }
            return false;
        }

        public void Resetear()
        {
            _posicion = -1;
            _orden.Clear();
            _orden.AddRange(OrdenarAleatoriamente(_canciones.Count));
        }


        private List<int> OrdenarAleatoriamente(int count)
        {
            var numeros = Enumerable.Range(0, count);
            return numeros.Shuffle().ToList();
        }
    }
}
