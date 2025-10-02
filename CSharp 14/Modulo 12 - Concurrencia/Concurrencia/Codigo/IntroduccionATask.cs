using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrencia.Codigo
{
    internal class IntroduccionATask
    {
        // Excepción a la regla de async void pues es un event handler
        private async void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;

            await RealizarProcesamientoLargo();

            var nombre = await ObtenerNombre();

            MessageBox.Show($"Hola, {nombre}");

            //pictureBox1.Visible = false;
        }

        private async Task RealizarProcesamientoLargo()
        {
            await Task.Delay(500);
        }

        private async Task<string> ObtenerNombre()
        {
            await Task.Delay(100);
            return "Claudia";
        }
    }
}
