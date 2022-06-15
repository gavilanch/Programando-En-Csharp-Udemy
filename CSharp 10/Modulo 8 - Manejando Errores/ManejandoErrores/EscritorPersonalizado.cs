using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejandoErrores
{
    internal class EscritorPersonalizado : TextWriter
    {
        public override Encoding Encoding => throw new NotImplementedException();

        public override void WriteLine(string? value)
        {
            Console.WriteLine(
                $"{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt")}: {value}");
        }
    }
}
