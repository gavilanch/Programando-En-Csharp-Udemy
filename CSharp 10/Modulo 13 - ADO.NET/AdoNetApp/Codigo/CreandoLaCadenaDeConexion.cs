using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetApp.Codigo
{
    internal class CreandoLaCadenaDeConexion
    {
        internal void CodigoDelCurso()
        {
            // Nota: El Data Source en tu caso es otro.

            // Por si acaso necesitas usar usuario y password
            //var cadenaConexión2 = "Data Source=LAPTOP-4KBFRF57;Database=AdoNetDemo;Integrated Security=False;User Id=miUsuario;Password=miPassword;TrustServerCertificate=True";

            // Cadena de conexión que trabaja con windows authentication
            var cadenaConexión = "Data Source=LAPTOP-4KBFRF57;Database=AdoNetDemo;Integrated Security=True;TrustServerCertificate=True";
        }
    }
}
