using System;
using System.Collections.Generic;
using System.Text;

namespace Cadena_De_Responsabilidad.Validaciones
{
    public interface IValidador<T>
    {
        IValidador<T> SetearSiguiente(IValidador<T> siguiente);
        ValidationResult RealizarValidaciones(T modelo);
    }
}
