
using System.Reflection;
using Variables.Ejercicios;

namespace Pruebas
{
    [TestClass]
    public class OtrasOperacionesBinariasPruebas
    {
        [DataRow(1,24)]
        [DataRow(2,25)]
        [DataRow(7,30)]
        [DataRow(-1,22)]
        [DataTestMethod]
        public void ElMétodoDevuelveElValorCorrecto(int parametro, int esperado)
        {
            var clase = new OtrasOperacionesBinarias();
            var respuesta = clase.Ejercicio(parametro);
            Assert.AreEqual(esperado, respuesta, $"Respuesta esperada {esperado}. Respuesta obtenida: {respuesta}");
        }
    }
}