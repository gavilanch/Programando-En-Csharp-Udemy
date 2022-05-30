using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesyBucles.Codigo
{
    internal class SentenciaSwitch
    {
        public void CodigoDelCurso()
        {
            var lugar = 6;

            //if (lugar == 1)
            //{
            //    Console.WriteLine("¡Quedaste en primer lugar!");
            //}
            //else if (lugar == 2)
            //{
            //    Console.WriteLine("¡Quedaste en segundo lugar!");
            //}
            //else if (lugar == 3)
            //{
            //    Console.WriteLine("¡Puedes vender tu medalla de bronce en una compraventa!");
            //}
            //else
            //{
            //    Console.WriteLine("¡Mejor suerte para la próxima!");
            //}

            switch (lugar)
            {
                case 1:
                    Console.WriteLine("¡Quedaste en primer lugar!");
                    break;
                case 2:
                    Console.WriteLine("¡Quedaste en segundo lugar!");
                    Console.WriteLine("esta linea pertenece al case 2");
                    break;
                case 3:
                    Console.WriteLine("¡Puedes vender tu medalla de bronce en una compraventa!");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Casi casi lo lograste");
                    break;
                default:
                    Console.WriteLine("¡Mejor suerte para la próxima!");
                    break;
            }
        }
    }
}
