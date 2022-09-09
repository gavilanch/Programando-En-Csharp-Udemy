using DecisionesyBucles.Ejercicios;

namespace Pruebas
{
    [TestClass]
    public class NumeroMayorPruebas
    {
        [DataRow(1, 2, 2)]
        [DataRow(2, 30, 30)]
        [DataRow(-7, -10, -7)]
        [DataRow(1, 0, 1)]
        [DataTestMethod]
        public void ElMétodoDevuelveElValorCorrecto(int a, int b, int esperado)
        {
            var clase = new NumeroMayor();
            var respuesta = clase.DeterminarElNumeroMayor(a, b);
            Assert.IsTrue(respuesta == esperado, "Respuesta esperada: " + esperado + ". Respuesta obtenida: " + respuesta);
        }
    }
}