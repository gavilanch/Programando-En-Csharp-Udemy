
using System.Reflection;
using Variables.Ejercicios;

namespace Pruebas
{
    [TestClass]
    public class EscapandoUnStringPruebas
    {
        [TestMethod]
        public void ElM�todoDevuelveElStringCorrecto()
        {
            var clase = new EscapandoUnString();
            var tipo = clase.GetType();

            var metodo = tipo.GetMember("Ejercicio");

            if (metodo.Length == 0)
            {
                Assert.Fail("Debes implementar el m�todo Ejercicio");
            }

            var respuesta = tipo.InvokeMember("Ejercicio", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.InvokeMethod, 
                null, clase, new object[] { });

            if (respuesta is null)
            {
                Assert.Fail("El m�todo no debe retornar null");
            }

            if (respuesta is not string)
            {
                Assert.Fail("El tipo de dato de retorno debe ser un string");
            }

            var esperado = "Este string contiene \\ y tambi�n \" pues lo escapamos";
            Assert.AreEqual(esperado, respuesta.ToString());
        }
    }
}