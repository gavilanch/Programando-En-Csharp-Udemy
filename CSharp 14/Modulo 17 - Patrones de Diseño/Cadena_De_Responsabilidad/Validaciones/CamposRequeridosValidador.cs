using Cadena_De_Responsabilidad.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadena_De_Responsabilidad.Validaciones
{
    public class CamposRequeridosValidador : ValidadorBase<RegistroUsuario>
    {
        protected override ValidationResult Validar(RegistroUsuario req)
        {
            if (string.IsNullOrWhiteSpace(req.Nombre))
                return ValidationResult.ConError("El nombre es requerido.");
            if (string.IsNullOrWhiteSpace(req.Email))
                return ValidationResult.ConError("El email es requerido.");
            if (string.IsNullOrWhiteSpace(req.Contraseña))
                return ValidationResult.ConError("La contraseña es requerida.");

            return ValidationResult.Ok();
        }
    }
}
