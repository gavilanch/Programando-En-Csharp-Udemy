namespace Clases
{
    internal class Carro
    {
        internal Carro(): this("marca por defecto")
        {
            Console.WriteLine("Instanciando un carro");
        }

        internal Carro(string marca)
        {
            Console.WriteLine("Instanciando un carro con una marca");
            _marca = marca;
            ConteoInstancias++;
        }

        internal void Acelerar()
        {
            Acelerar(1);
        }

        public static int ConteoInstancias { get; set; }

        // Por convención, los campos empiezan con guión bajo
        private string _marca;

        internal string Marca
        {
            get { return _marca.ToUpper(); }
            set { _marca = value; }
        }

        internal int Año { get; set; } = 1990;

        internal int Velocidad { get; private set; } = 20;
        private int VelocidadMaxima => 120;
        internal string NombreComercial => $"{Marca} ({Año})";

        

        internal void Acelerar(int incremento)
        {
            if (Velocidad >= VelocidadMaxima)
            {
                Console.WriteLine("La velocidad máxima ya ha sido alcanzada");
                return;
            } else if(Velocidad + incremento > VelocidadMaxima)
            {
                incremento = VelocidadMaxima - Velocidad;
            }

            Velocidad += incremento;
        }

        internal void Detener() => Velocidad = 0;
    }
}
