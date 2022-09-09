using Funciones.Ejercicios;
using System.Reflection;
using System.Text;

namespace Pruebas
{
    [TestClass]
    public class FuncionesAnonimasPruebas
    {
        [TestMethod]
        public void VerificaResultadoCorrecto()
        {
            var clase = new FuncionesAnonimas();
            int a = 3, b = 2, veces = 4;

            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                MethodInfo? metodo = clase.GetType().GetMethod("ImprimirSumaYMultiplicacion",
       BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

                if (metodo is null)
                {
                    Assert.Fail("Falta el método ImprimirSumaYMultiplicacion");
                }

                metodo.Invoke(clase, new object[] { a, b, veces });

                // Restore the original standard output.
                Console.SetOut(stdout);

                var esperado = ImprimirSumaYMultiplicacion(a, b, veces);

                // Assert
                var respuesta = sw.ToString();
                Assert.IsTrue(respuesta == esperado, "Te recomiendo que hagas una app de consola y verifiques el resultado con tus propios ojos. Ya que al ser muchas líneas es difícil de mostrar por aquí.");
            }


        }

        private string ImprimirSumaYMultiplicacion(int a, int b, int veces)
        {
            var sb = new StringBuilder();
            Func<int, int, int> sumar = (x, y) => x + y;

            Func<int, int, int> multiplicar = (x, y) => x * y;

            Action<int, int, int> imprimir = (resultadoSuma, resultadoMultiplicacion, n) =>
            {
                for (int i = 0; i < n; i++)
                {
                    sb.AppendLine($"{resultadoSuma} - {resultadoMultiplicacion}");
                }
            };

            int suma = sumar(a, b);
            int multiplicacion = multiplicar(a, b);
            imprimir(suma, multiplicacion, veces);
            return sb.ToString();
        }
    }
}