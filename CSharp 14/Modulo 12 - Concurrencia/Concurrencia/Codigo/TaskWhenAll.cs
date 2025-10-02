using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrencia.Codigo
{
    internal class TaskWhenAll
    {
        private async void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;

            var sw = new Stopwatch();

            sw.Start();

            //await RealizarProcesamientoLargoA();
            //await RealizarProcesamientoLargoB();
            //await RealizarProcesamientoLargoC();

            var tareas = new List<Task>()
            {
                RealizarProcesamientoLargoA(),
                RealizarProcesamientoLargoB(),
                RealizarProcesamientoLargoC()
            };

            await Task.WhenAll(tareas);

            sw.Stop();

            var duración =
                $"El programa se ejecutó en {sw.ElapsedMilliseconds / 1000.0} segundos";

            Console.WriteLine(duración);

            //pictureBox1.Visible = false;
        }

        private async Task RealizarProcesamientoLargoA()
        {
            await Task.Delay(1000);
            Console.WriteLine("Proceso A finalizado");
        }

        private async Task RealizarProcesamientoLargoB()
        {
            await Task.Delay(1000);
            Console.WriteLine("Proceso B finalizado");
        }

        private async Task RealizarProcesamientoLargoC()
        {
            await Task.Delay(1000);
            Console.WriteLine("Proceso C finalizado");
        }
    }
}
