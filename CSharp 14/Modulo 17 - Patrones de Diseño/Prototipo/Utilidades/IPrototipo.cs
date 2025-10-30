using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo.Utilidades
{
    public interface IPrototipo<T>
    {
        T Clonar();
    }
}
