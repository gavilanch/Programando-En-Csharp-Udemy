using ResolviendoUnEjercicio.Ejercicios;

namespace Pruebas
{
    [TestClass]
    public class EjemploPruebas
    {
        [TestMethod]
        public void DevolverVerdadero_DevuelveVerdadero()
        {
            var clase = new Ejemplo();
            var resultado = clase.DevolverVerdadero();
            Assert.AreEqual(true, resultado, $"Se esperaba {true}, pero se obtuvo {resultado}");
        }
    }
}