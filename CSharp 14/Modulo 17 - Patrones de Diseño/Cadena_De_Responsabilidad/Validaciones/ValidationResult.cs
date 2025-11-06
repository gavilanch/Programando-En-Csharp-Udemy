using System;
using System.Collections.Generic;
using System.Text;

namespace Cadena_De_Responsabilidad.Validaciones
{
    public record ValidationResult(bool EsExitoso, string? Error = null)
    {
        public static ValidationResult Ok() => new(true);
        public static ValidationResult ConError(string error) => new(false, error);
    }

}
