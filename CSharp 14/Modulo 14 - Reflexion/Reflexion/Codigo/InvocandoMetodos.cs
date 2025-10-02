using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion.Codigo
{
    internal class InvocandoMetodos
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Invocando un método void sin parámetros 

            var tipo = typeof(Utilidades);
            var utilidades = Activator.CreateInstance(tipo);

            tipo.InvokeMember("ImprimirHoraActual", BindingFlags.InvokeMethod,
                binder: null, target: utilidades, args: new object[] { });

            // Ejemplo 2: Invocando un método void pasando parámetros

            tipo.InvokeMember("ImprimirMensaje", BindingFlags.InvokeMethod,
                binder: null, target: utilidades, args: new object[] { "Usando reflexión" });

            // Ejemplo 3: Invocando un método que devuelve un valor

            var resultado = tipo.InvokeMember("ObteniendoUnValor", BindingFlags.InvokeMethod,
                binder: null, utilidades, new object[] { });

            Console.WriteLine("Obtuvimos el valor: " + resultado);

            // Ejemplo 4: Invocando un método estático

            tipo.InvokeMember("MetodoEstatico", BindingFlags.InvokeMethod,
                binder: null, target: null, args: new object[] { });

            // Ejemplo 5: invocando un método privado

            tipo.InvokeMember("MetodoPrivado",
                BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance,
                binder: null, target: utilidades, args: new object[] { });

        }
    }
}
