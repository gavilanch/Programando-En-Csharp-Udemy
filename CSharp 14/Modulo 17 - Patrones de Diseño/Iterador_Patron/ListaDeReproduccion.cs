using System;
using System.Collections.Generic;
using System.Text;

namespace Iterador_Patron
{
    public class ListaDeReproduccion : IColeccion<Cancion>
    {
        private readonly List<Cancion> _canciones = new();
        public void Agregar(Cancion cancion) => _canciones.Add(cancion);
        
        public IIterador<Cancion> CrearIterador() => new AdelanteListaDeReproduccionIterador(_canciones);
        
        public IIterador<Cancion> CrearIterador(ModoIteracion modo) => modo switch
        {
            ModoIteracion.Adelante => new AdelanteListaDeReproduccionIterador(_canciones),
            ModoIteracion.Reversa => new ReversaListaDeReproduccionIterador(_canciones),
            ModoIteracion.Aleatorio => new AleatorioListaDeReproduccionIterador(_canciones),
            _ => new AdelanteListaDeReproduccionIterador(_canciones)
        };

    }
}
