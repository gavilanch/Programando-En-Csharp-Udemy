using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Codigo
{
    internal class FuncionesLocales
    {
        public void CodigoDelCurso()
        {
            SumarEImprimir();
        }

        void SumarEImprimir()
        {
            var cantidad = 5;
            ImprimirValor(cantidad);
            cantidad++;
            ImprimirValor(cantidad);

            void ImprimirValor(int cantidad)
            {
                Console.WriteLine("El valor es " + cantidad);
            }
        }
    }
}
