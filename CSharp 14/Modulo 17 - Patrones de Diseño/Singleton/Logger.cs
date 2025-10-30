using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class Logger
    {
        private Logger()
        {
            Console.WriteLine("Instanciando el Logger");
        }

        private static readonly Lazy<Logger> _lazyLogger = new(() => new Logger());
        public static Logger Instancia => _lazyLogger.Value;
    }
}
