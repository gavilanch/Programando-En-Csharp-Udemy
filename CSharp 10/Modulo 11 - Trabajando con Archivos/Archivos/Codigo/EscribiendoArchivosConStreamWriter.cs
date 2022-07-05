using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Codigo
{
    internal class EscribiendoArchivosConStreamWriter
    {
        public void CodigoDelCurso()
        {
            var ruta = @"..\..\..\mensaje.txt";
            var streamWriter = new StreamWriter(ruta, append: true);

            streamWriter.WriteLine("Buenos días");
            streamWriter.Write("En esta carta ");
            streamWriter.WriteLine($"te informo que la hora es {DateTime.Now.ToString("hh:mm:ss")}");
            streamWriter.Write("bye");
            streamWriter.Dispose();
        }
    }
}
