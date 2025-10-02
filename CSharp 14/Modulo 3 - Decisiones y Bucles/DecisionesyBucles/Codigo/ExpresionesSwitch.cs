using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class ExpresionesSwitch
    {
        public void CodigoDelCurso()
        {
            var lugar = 3;

            var mensaje = lugar switch
            {
                1 => "¡Quedaste en primer lugar!",
                2 => "¡Quedaste en segundo lugar!",
                3 => "¡Puedes vender tu medalla de bronce en una compraventa!",
                4 or 5 => "Casi casi lo lograste",
                _ => "¡Mejor suerte para la próxima!"
            };

            Console.WriteLine(mensaje);

            // Podemos saltarnos el asignar la variable y pasarle el resultado directamente al WriteLine:
            //Console.WriteLine(lugar switch
            //{
            //    1 => "¡Quedaste en primer lugar!",
            //    2 => "¡Quedaste en segundo lugar!",
            //    3 => "¡Puedes vender tu medalla de bronce en una compraventa!",
            //    4 or 5 => "Casi casi lo lograste",
            //    _ => "¡Mejor suerte para la próxima!"
            //});
        }
    }
}
