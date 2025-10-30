using System;
using System.Collections.Generic;
using System.Text;

namespace Comando.Modelos
{
    public class Cuenta
    {
        public required string Titular { get; init; }
        public decimal Saldo { get; set; }
    }

}
