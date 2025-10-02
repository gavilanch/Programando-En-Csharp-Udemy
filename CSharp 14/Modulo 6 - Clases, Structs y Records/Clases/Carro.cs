namespace Clases
{
    internal class Carro
    {
        internal string Marca
        {
            get { return field.ToUpper(); }
            set { field = value; }
        }

        internal int Año { get; set; } = 1990;

        internal int Velocidad { get; private set; } = 20;
        internal string NombreComercial => $"{Marca} ({Año})";
    }
}
