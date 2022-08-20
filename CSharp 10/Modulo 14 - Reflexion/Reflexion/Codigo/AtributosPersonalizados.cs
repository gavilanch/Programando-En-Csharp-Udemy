using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion.Codigo
{
    internal class AtributosPersonalizados
    {
        public void CodigoDelCurso()
        {
            Console.WriteLine("--Puedes realizar las siguientes acciones--");

            foreach (var accion in Enum.GetValues<Acciones>())
            {
                var campo = typeof(Acciones).GetField(accion.ToString())!;
                var esconderAtributo = campo.GetCustomAttribute(typeof(EsconderAttribute));

                if (esconderAtributo is not null)
                {
                    var esconder = ((EsconderAttribute)esconderAtributo).Ocultar();

                    if (esconder)
                    {
                        continue;
                    }
                }

                Console.WriteLine(accion);
            }
        }
    }
}
