using System;
using System.Collections.Generic;
using System.Text;

namespace Iterador_Patron
{
    public interface IColeccion<T>
    {
        IIterador<T> CrearIterador();
    }
}
