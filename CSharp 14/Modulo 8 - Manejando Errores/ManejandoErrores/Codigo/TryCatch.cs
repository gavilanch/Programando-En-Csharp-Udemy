using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores.Codigo
{
    internal class TryCatch
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
                ClasesA.ProcesarA();
                Console.WriteLine("Después del error");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("Ha ocurrido una excepción");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ha ocurrido una excepción");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido una excepción que no había contemplado");
            }

            Console.WriteLine("Fin del programa");
        }
    }
}
