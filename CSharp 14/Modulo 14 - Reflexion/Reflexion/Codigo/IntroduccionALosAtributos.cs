using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion.Codigo
{
    internal class IntroduccionALosAtributos
    {
        public void CodigoDelCurso()
        {
            var persona = new Persona();

            persona.Edad = 17;
            persona.OtroNumero = 7;

            var errores = ValidarObjeto(persona);

            if (errores.Any())
            {
                Console.WriteLine("La persona no tiene los datos correctos");

                foreach (var error in errores)
                {
                    Console.WriteLine($"- Propiedad: {error.Propiedad}; Mensaje: {error.MensajeDeError}");
                }

                return;
            }

            Console.WriteLine("La edad de la persona es: " + persona.Edad);

            Console.WriteLine("Fin");

            bool ValidarPersona(Persona p)
            {
                var tipo = p.GetType();

                var propiedadEdad = tipo.GetProperty("Edad")!;

                if (propiedadEdad.IsDefined(typeof(RangeAttribute)))
                {
                    var atributoRange = (RangeAttribute)Attribute
                            .GetCustomAttribute(propiedadEdad, typeof(RangeAttribute))!;

                    return p.Edad >= (int)atributoRange.Minimum && p.Edad <= (int)atributoRange.Maximum;
                }

                return true;
            }

            IEnumerable<ErrorValidacion> ValidarObjeto(object obj)
            {
                var t = obj.GetType();
                var propiedades = t.GetProperties();
                var resultado = new List<ErrorValidacion>();

                foreach (var propiedad in propiedades)
                {
                    if (propiedad.IsDefined(typeof(RangeAttribute)))
                    {
                        var atributoRange = (RangeAttribute)Attribute
                            .GetCustomAttribute(propiedad, typeof(RangeAttribute))!;
                        var valor = (int)propiedad.GetValue(obj)!;
                        var minimo = (int)atributoRange.Minimum;
                        var maximo = (int)atributoRange.Maximum;
                        var esValido = valor >= minimo && valor <= maximo;
                        if (!esValido)
                        {
                            resultado.Add(new ErrorValidacion
                            {
                                Propiedad = propiedad.Name,
                                MensajeDeError = $"El valor debe de estar entre {minimo} y {maximo}"
                            });
                        }
                    }
                }

                return resultado;
            }
        }
    }
}
