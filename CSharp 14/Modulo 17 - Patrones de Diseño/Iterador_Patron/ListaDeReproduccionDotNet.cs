using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterador_Patron
{
    public class ListaDeReproduccionDotNet : IEnumerable<Cancion>
    {
        private readonly List<Cancion> _canciones = new();
        public void Agregar(Cancion cancion) => _canciones.Add(cancion);
        
        public IEnumerator<Cancion> GetEnumerator() => new AdelanteListaDeReproduccionIteradorDotNet(_canciones);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
