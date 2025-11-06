using System;
using System.Collections.Generic;
using System.Text;

namespace Iterador_Patron
{
    public interface IIterador<T>
    {
        bool MoverHaciaSiguiente();
        T Actual { get; }
        void Resetear();
    }

}
