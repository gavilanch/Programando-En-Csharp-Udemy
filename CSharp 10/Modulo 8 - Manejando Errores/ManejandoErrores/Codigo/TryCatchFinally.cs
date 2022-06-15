using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores.Codigo
{
    internal class TryCatchFinally
    {
        internal class ClasesA
        {
            public static void ProcesarA()
            {
                ClasesB.ProcesarB();
            }
        }

        internal class ClasesB
        {
            public static void ProcesarB()
            {
                ClasesC.ProcesarC();
            }
        }

        internal class ClasesC
        {
            public static void ProcesarC()
            {
                throw new FileNotFoundException("El archivo de word no ha sido encontrado");
            }
        }


        public void CodigoDelCurso()
        {
            try
            {
                Console.WriteLine("Antes del error");
                //ClasesA.ProcesarA();
                Console.WriteLine("Después del error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido una excepción que no había contemplado");
            }
            finally
            {
                Console.WriteLine("Este es el bloque del finally");
            }

            Console.WriteLine("Fin del programa");
        }
    }
}
