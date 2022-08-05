using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrencia.Codigo
{
    internal class DescargarImagenes
    {
        HttpClient httpClient = new HttpClient();

        private async void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;

            var directorioActual = AppDomain.CurrentDomain.BaseDirectory;
            var destinoBaseSecuencial = Path.Combine(directorioActual,
                @"Imagenes\resultado-secuencial");

            var destinoBaseParalelo = Path.Combine(directorioActual,
               @"Imagenes\resultado-paralelo");

            PrepararEjecución(destinoBaseParalelo, destinoBaseSecuencial);

            Console.WriteLine("Inicio");
            var imagenes = ObtenerImagenes();

            // Parte secuencial

            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (var imagen in imagenes)
            {
                await ProcesarImagen(destinoBaseSecuencial, imagen);
            }

            Console.WriteLine(
                $"Secuencial - duración en segundos es {sw.ElapsedMilliseconds / 1000.0}");

            sw.Reset();

            // Parte en paralelo

            sw.Start();

            var tareasEnumerable = imagenes.Select(async imagen =>
            {
                await ProcesarImagen(destinoBaseParalelo, imagen);
            });

            await Task.WhenAll(tareasEnumerable);

            sw.Stop();

            Console.WriteLine(
               $"Paralelo - duración en segundos es {sw.ElapsedMilliseconds / 1000.0}");

            //pictureBox1.Visible = false;
        }

        private async Task ProcesarImagen(string directorio, Imagen imagen)
        {
            var respuesta = await httpClient.GetAsync(imagen.URL);
            var contenido = await respuesta.Content.ReadAsByteArrayAsync();

            Bitmap bitmap;
            using (var ms = new MemoryStream(contenido))
            {
                bitmap = new Bitmap(ms);
            }

            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            var destino = Path.Combine(directorio, imagen.Nombre);
            bitmap.Save(destino);
        }

        private void PrepararEjecución(string destinoBaseParalelo,
            string destinoBaseSecuencial)
        {
            if (!Directory.Exists(destinoBaseParalelo))
            {
                Directory.CreateDirectory(destinoBaseParalelo);
            }

            if (!Directory.Exists(destinoBaseSecuencial))
            {
                Directory.CreateDirectory(destinoBaseSecuencial);
            }

            BorrarArchivos(destinoBaseParalelo);
            BorrarArchivos(destinoBaseSecuencial);
        }

        private void BorrarArchivos(string directorio)
        {
            var archivos = Directory.EnumerateFiles(directorio);
            foreach (var archivo in archivos)
            {
                File.Delete(archivo);
            }
        }

        private List<Imagen> ObtenerImagenes()
        {
            var imagenes = new List<Imagen>();

            for (int i = 0; i < 7; i++)
            {
                imagenes.Add(new Imagen()
                {
                    Nombre = $"Cacicazgos {i}.png",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/Copia_de_Cacicazgos_de_la_Hispaniola.png/800px-Copia_de_Cacicazgos_de_la_Hispaniola.png"
                });

                imagenes.Add(new Imagen()
                {
                    Nombre = $"Desangles {i}.jpg",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/4/43/Desangles_Colon_engrillado.jpg"
                });

                imagenes.Add(new Imagen()
                {
                    Nombre = $"Alcazar {i}.jpg",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/Santo_Domingo_-_Alc%C3%A1zar_de_Col%C3%B3n_0777.JPG/800px-Santo_Domingo_-_Alc%C3%A1zar_de_Col%C3%B3n_0777.JPG"
                });
            }

            return imagenes;
        }
    }
}
