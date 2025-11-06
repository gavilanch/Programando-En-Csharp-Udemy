using Cadena_De_Responsabilidad.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadena_De_Responsabilidad.Validaciones
{
    public class EmailYaExisteValidador : ValidadorBase<RegistroUsuario>
    {
        private List<string> _emailsExistentes = ["claudia@ejemplo.com"];

        protected override ValidationResult Validar(RegistroUsuario req)
        {
            if (_emailsExistentes.Contains(req.Email))
                return ValidationResult.ConError($"El email {req.Email} ya se encuentra en la base de datos");
            return ValidationResult.Ok();
        }

    }
}
