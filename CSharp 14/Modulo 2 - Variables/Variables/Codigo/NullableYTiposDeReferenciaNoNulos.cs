using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Codigo
{
    internal class NullableYTiposDeReferenciaNoNulos
    {
        public void CodigoDelCurso()
        {
            // Un tipo de valor puede ser nulificable si le ponemos un ?
            int? edad = null;

            Console.WriteLine("Valor por defecto de int: ");
            Console.WriteLine(edad);

            // Por defecto, los tipos de referencia son no-nulificables, para indicar
            // que pueden ser null colocamos ?
            string? nombre = null;

            Console.WriteLine("Valor por defecto de string: ");
            // Peligro: Va a dar un error de referencia nula si ejecutas este código
            Console.WriteLine(nombre.ToUpper());
        }
    }
}
