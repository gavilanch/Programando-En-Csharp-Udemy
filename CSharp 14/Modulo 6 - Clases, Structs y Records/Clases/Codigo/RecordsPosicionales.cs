using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Codigo
{
    internal class RecordsPosicionales
    {
        // Por defecto un record posicional de clase es inmutable
        internal record Empresa(string Nombre, int AñoFundación);

        // Si es un record struct, debe ser readonly para que sea inmutable
        internal readonly record struct EmpresaStruct(string Nombre, int AñoFundación);

        public void CodigoDelCurso()
        {
            var empresa1 = new Empresa("Udemy", 2010);

            // Error, no podemos modificar nombre, es inmutable
            //empresa1.Nombre = "Google";

            var (nombre, año) = empresa1;

            Console.WriteLine("Nombre de la empresa: " + nombre);
            Console.WriteLine("Año de la empresa: " + año);

        }
    }
}
