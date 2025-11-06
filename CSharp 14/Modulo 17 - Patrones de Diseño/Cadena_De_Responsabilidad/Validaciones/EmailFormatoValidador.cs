using Cadena_De_Responsabilidad.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadena_De_Responsabilidad.Validaciones
{
    public class EmailFormatoValidador : ValidadorBase<RegistroUsuario>
    {
        protected override ValidationResult Validar(RegistroUsuario req)
        {
            if (!req.Email.Contains("@"))
                return ValidationResult.ConError("El email no tiene un formato válido.");
            return ValidationResult.Ok();
        }
    }
}
