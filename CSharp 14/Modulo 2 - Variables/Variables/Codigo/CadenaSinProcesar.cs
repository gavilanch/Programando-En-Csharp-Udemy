using System;
using System.Collections.Generic;
using System.Text;

namespace Variables.Codigo
{
    internal class CadenaSinProcesar
    {
        public void CodigoDelCurso()
        {
            string miPrimerCSP = """"Hola, """mucho gusto""", soy Felipe"""";

            Console.WriteLine(miPrimerCSP);

            string carta = """
                                                    A quien pueda interesar:

                                    Estimado cliente, me debe dinero. El banco dice: "páguenos".

                                    Att: La administración
                                    """;

            Console.WriteLine(carta);
        }
    }
}
