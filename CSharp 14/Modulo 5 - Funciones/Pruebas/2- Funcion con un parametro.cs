using Funciones.Ejercicios;
using System.Reflection;

namespace Pruebas
{
    [TestClass]
    public class FuncionConParametroPruebas
    {
        [TestMethod]
        public void VerificaRetornaValorCorrecto()
        {
            var clase = new FuncionConParametro();

            MethodInfo? metodo = clase.GetType().GetMethod("Saludar",
         BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            if (metodo is null)
            {
                Assert.Fail("Falta el método 'Saludar'");
            }

            var respuestaObj = metodo.Invoke(clase, new object[] { "Felipe" });

            if (respuestaObj is null)
            {
                Assert.Fail("El método debe devolver un valor");
            }

            var respuesta = respuestaObj.ToString();

            string esperado = "Hola, Felipe";

            //var respuesta = clase.Saludar(nombre);
            Assert.IsTrue(respuesta == esperado, "Respuesta esperada: " + esperado + ". Respuesta obtenida: " + respuesta);
        }
    }
}