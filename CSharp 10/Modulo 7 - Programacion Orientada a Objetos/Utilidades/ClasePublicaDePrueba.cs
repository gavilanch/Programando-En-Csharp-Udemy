namespace Utilidades
{
    public class ClasePublicaDePrueba
    {
        public int PropiedadPublica { get; set; }
        internal int PropiedadInterna { get; set; }
        protected int PropiedadProtegida { get; set; }
        protected internal int PropiedadProtectedInternal { get; set; }
        private protected int PropiedadPrivateProtected { get; set; }

        public void MetodoPublico()
        {
            PropiedadInterna = 1;
            PropiedadProtegida = 2;
            PropiedadProtectedInternal = 3;
            PropiedadProtectedInternal = 4;
            Console.WriteLine("Soy un método público de otro proyecto");
            MetodoPrivado();
        }

        private void MetodoPrivado()
        {
            var claseInterna = new ClaseInterna();
        }

        private class ClaseInterna
        {

        }
    }
}