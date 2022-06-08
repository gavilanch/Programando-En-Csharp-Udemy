using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal interface IMiInterfaz
    {
        void MiMetodo1();
        string MiMetodo2(int param1);
        void MiMetodo3();
        bool MiPropiedad1 { get; set; }
        int MiPropiedadDeSoloLectura { get; }
    }

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


    internal class MiClase : IMiInterfaz, IMiSegundaInterfaz
    {
        public bool MiPropiedad1 { get; set; }

        public int MiPropiedadDeSoloLectura => 42;

        public void MiMetodo1()
        {
        }

        public string MiMetodo2(int param1)
        {
            return "Ejemplo";
        }

        public void MiMetodo3()
        {
            throw new NotImplementedException();
        }

        public void MiMetodoDeLaSegundaInterfaz()
        {
            throw new NotImplementedException();
        }
    }

    public record MiRecord(string param1) : IMiSegundaInterfaz
    {
        public void MiMetodoDeLaSegundaInterfaz()
        {
            throw new NotImplementedException();
        }
    }

    public struct MiStruct : IMiSegundaInterfaz
    {
        public void MiMetodoDeLaSegundaInterfaz()
        {
            throw new NotImplementedException();
        }
    }
}
