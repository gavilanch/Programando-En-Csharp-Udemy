using System;
using System.Collections.Generic;
using System.Text;

namespace Cadena_De_Responsabilidad.Validaciones
{
    public abstract class ValidadorBase<T>: IValidador<T>
    {
        private IValidador<T>? _siguiente;

        public IValidador<T> SetearSiguiente(IValidador<T> siguiente)
        {
            _siguiente = siguiente;
            return siguiente;
        }

        public ValidationResult RealizarValidaciones(T modelo)
        {
            var resultado = Validar(modelo);
            if (!resultado.EsExitoso || _siguiente is null)
                return resultado;

            return _siguiente.RealizarValidaciones(modelo);
        }

        protected abstract ValidationResult Validar(T request);

    }
}
