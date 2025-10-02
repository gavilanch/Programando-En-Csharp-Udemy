using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionesyBucles.Codigo
{
    internal class InterpolacionDeStringsVariasLineas
    {
        public void CodigoDelCurso()
        {
            var lugar = 4;

            var mensaje = $"A continuación tu resultado: {lugar switch
            {
                1 => "¡Quedaste en primer lugar!",
                2 => "¡Quedaste en segundo lugar!",
                3 => "¡Puedes vender tu medalla de bronce en una compraventa!",
                4 or 5 => "Casi casi lo lograste",
                _ => "¡Mejor suerte para la próxima!"
            }}. Esto ha sido todo por hoy";

            Console.WriteLine(mensaje);
        }
    }
}
