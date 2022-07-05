using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class InterfazIDisposable
    {
        public void CodigoDelCurso()
        {
            var ruta = @"..\..\..\ejemplo dispose.txt";
            using (var streamWriter = new StreamWriter(ruta, append: true))
            {
                streamWriter.WriteLine("Buenos días");
                streamWriter.Write("En esta carta ");
                streamWriter.WriteLine($"te informo que la hora es {DateTime.Now.ToString("hh:mm:ss")}");
                streamWriter.Write("bye");
            }

            Console.WriteLine("El programa va a ser detenido. Presione Enter para finalizar");

            Console.Read();

        }

        private void UsarSW(string ruta)
        {
            // Podemos usar esta notación en métodos pequeños como este.
            using var streamWriter = new StreamWriter(ruta, append: true);
            streamWriter.WriteLine("Buenos días");
            streamWriter.Write("En esta carta ");
            streamWriter.WriteLine($"te informo que la hora es {DateTime.Now.ToString("hh:mm:ss")}");
            streamWriter.Write("bye");
        }
    }
}
