using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores
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
            try
            {
                throw new FileNotFoundException("El archivo de word no ha sido encontrado");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Procesando la excepción");
                throw;
            }
        }
    }

}
