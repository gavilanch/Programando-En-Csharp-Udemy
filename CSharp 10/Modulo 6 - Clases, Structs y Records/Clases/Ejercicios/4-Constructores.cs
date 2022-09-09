namespace Clases.Ejercicios.Ejercicio4
{
    /*
    Debajo tenemos una clase Persona, la cual tiene 3 propiedades. En esta clase debes colocar dos constructores:

    1) El primer constructor tendrá los valores de Nombre y Apellido (en ese mismo orden).

    2) El segundo constructor tendrá los valores de Nombre, Apellido y FechaNacimiento (en ese mismo orden).

    Nota: Si vas a utilizar el valor por defecto de un tipo (como DateTime)
     */

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}