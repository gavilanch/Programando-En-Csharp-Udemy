using DecisionesyBucles.Ejercicios;

namespace Pruebas
{
    [TestClass]
    public class NumeroMayorPruebasParte2
    {
        [DataRow(1, 2, 2)]
        [DataRow(2, 30, 30)]
        [DataRow(-7, -10, -7)]
        [DataRow(1, 0, 1)]
        [DataTestMethod]
        public void ElMétodoDevuelveElValorCorrecto(int a, int b, int esperado)
        {
            var clase = new NumeroMayorParte2();
            var respuesta = clase.DeterminarElNumeroMayor(a, b);
            Assert.IsTrue(respuesta == esperado, "Respuesta esperada: " + esperado + ". Respuesta obtenida: " + respuesta);
        }

        [TestMethod]
        public void ElMetodoUsaOperadorTernario()
        {
            var rutaArchivo = @"..\..\..\..\DecisionesyBucles\Ejercicios\2- Cual es el Numero Mas Grande - Parte 2.cs";

            if (!File.Exists(rutaArchivo))
            {
                // Ignorar
                return;
            }

            var contenido = File.ReadAllText(rutaArchivo);
            var contenidoSinEspacios = contenido.Replace(" ", "");
            var ternario1 = "a > b ? a : b".Replace(" ", "");
            var ternario2 = "b > a ? b : a".Replace(" ", "");
            var contieneAlMenosUno = contenidoSinEspacios.Contains(ternario1) || contenidoSinEspacios.Contains(ternario2);

            if (!contieneAlMenosUno)
            {
                Assert.Fail("No fue detectado el operador ternario en el ejercicio");
            }

        }
    }
}