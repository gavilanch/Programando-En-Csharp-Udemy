using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class OperadorTernario
    {
        public void CodigoDelCurso()
        {
            bool usuarioEstaLogueado = true;

            //string mensajeBienvenida;

            //if (usuarioEstaLogueado)
            //{
            //    mensajeBienvenida = "¡Qué bueno que has vuelto!";
            //}
            //else
            //{
            //    mensajeBienvenida = "Logueate para comenzar";
            //}

            string mensajeBienvenida = usuarioEstaLogueado ? "¡Qué bueno que has vuelto!" : "Logueate para comenzar";
            // <condicion> ? <si la condición es true> : <si la condición es false>

            Console.WriteLine(mensajeBienvenida);
        }
    }
}
