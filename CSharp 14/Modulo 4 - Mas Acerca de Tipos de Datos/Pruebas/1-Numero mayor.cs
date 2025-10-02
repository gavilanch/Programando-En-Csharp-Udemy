using Variables.Ejercicios;

namespace Pruebas
{
    [TestClass]
    public class NumeroMayorPruebas
    {
        [DataRow(new int[] { 1, 2, 3 }, 3)]
        [DataRow(new int[] { 15 }, 15)]
        [DataRow(new int[] { -1, -2 }, -1)]
        [DataRow(new int[] { }, null)]
        [DataTestMethod]
        public void ElM�todoDevuelveElValorCorrecto(int[] numeros, int? esperado)
        {
            var clase = new NumeroMayor();
            var respuesta = clase.DeterminarElNumeroMayor(numeros);
            Assert.IsTrue(respuesta == esperado, "Respuesta esperada: " + esperado + ". Respuesta obtenida: " + respuesta);
        }
    }
}