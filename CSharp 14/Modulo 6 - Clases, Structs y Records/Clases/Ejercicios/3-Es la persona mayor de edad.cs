namespace Clases.Ejercicios.Ejercicio3
{
    /*
    Debajo tenemos una clase Persona, la cual tiene 3 propiedades. Una de ellas es FechaNacimiento. 
    Vamos a implementar un método, llamado EsMayorDeEdad, que, como su nombre lo indica, devuelve true si 
    la persona es mayor de edad, de otro modo, devuelve false.

    Nota: Para este ejercicio vamos a asumir que se cumple la mayoría de edad a los 18. Es decir, una persona 
    con una edad mayor o igual a 18, es mayor de edad.
      */

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}