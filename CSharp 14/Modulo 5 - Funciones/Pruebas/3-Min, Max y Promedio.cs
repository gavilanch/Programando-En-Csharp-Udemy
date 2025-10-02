using Funciones.Ejercicios;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class MixMaxPromedioPruebas
    {
        [DataRow(new int[] { 5 }, 5, 5, 5, true)]
        [DataRow(new int[] { }, 0, 0, 0, false)]
        [DataRow(new int[] { 1, 2, 3 }, 1, 3, 2, true)]
        [DataTestMethod]
        public void CalculaLosValoresCorrectos(int[] numeros, int minimoEsperado, int maximoEsperado, double promedioEsperado, bool boolEsperado)
        {
            var clase = new MinMaxPromedio();
            int minimo = 0, maximo = 0;
            double promedio = 0;

            MethodInfo? metodo = clase.GetType().GetMethod("ObtenerMinMaxPromedio",
          BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            if (metodo is null)
            {
                Assert.Fail("Falta el método 'ObtenerMinMaxPromedio'");
            }

            var args2 = new object[] { numeros, minimo, maximo, promedio };

            var respuesta = metodo.Invoke(clase, args2)!.ToString();
            minimo = (int)args2[1];
            maximo = (int)args2[2];
            promedio = (double)args2[3];

            Assert.IsTrue(respuesta == boolEsperado.ToString(), "Booleano esperado: " + boolEsperado + ". Respuesta obtenida: " + boolEsperado);

            if (boolEsperado)
            {
                Assert.IsTrue(minimoEsperado == minimo, "Valor mínimo esperado: " + minimoEsperado + ". Respuesta obtenida: " + minimo);
                Assert.IsTrue(minimoEsperado == minimo, "Valor máximo esperado: " + maximoEsperado + ". Respuesta obtenida: " + maximo);
                Assert.IsTrue(minimoEsperado == minimo, "Valor promedio esperado: " + promedioEsperado + ". Respuesta obtenida: " + promedio);
            }
        }
    }
}