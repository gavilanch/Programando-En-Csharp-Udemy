using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Codigo
{
    internal class PolimorfismoConInterfaces
    {
        internal interface IMiSegundaInterfaz
        {
            void MiMetodoDeLaSegundaInterfaz();
        }

        internal class ClaseA : IMiSegundaInterfaz
        {
            public void MiMetodoDeLaSegundaInterfaz()
            {
                Console.WriteLine("Implementación de la clase A");
            }
        }

        internal class ClaseB : IMiSegundaInterfaz
        {
            public void MiMetodoDeLaSegundaInterfaz()
            {
                Console.WriteLine("Implementación de la clase B");
            }
        }

        public void CodigoDelCurso()
        {
            var claseA = new ClaseA();
            var claseB = new ClaseB();

            Procesar(claseA);
            Procesar(claseB);

            void Procesar(IMiSegundaInterfaz miSegundaInterfaz)
            {
                miSegundaInterfaz.MiMetodoDeLaSegundaInterfaz();
            }
        }

    }
}
