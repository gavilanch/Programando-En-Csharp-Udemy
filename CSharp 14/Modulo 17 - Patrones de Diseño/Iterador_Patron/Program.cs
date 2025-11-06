// See https://aka.ms/new-console-template for more information

using Iterador_Patron;

//EjemploConPatronPersonalizado();
EjemploConInterfacesDeDotNet();

void MostrarEnConsola(IIterador<Cancion> iterador)
{
    iterador.Resetear();
    while (iterador.MoverHaciaSiguiente())
    {
        var cancion = iterador.Actual;
        Console.WriteLine($"- {cancion.Titulo} — {cancion.Artista}");
    }
}

void EjemploConInterfacesDeDotNet()
{
    var listaDeReproduccion = new ListaDeReproduccionDotNet();
    listaDeReproduccion.Agregar(new Cancion("Canción 1", "Cantante 1"));
    listaDeReproduccion.Agregar(new Cancion("Canción 2", "Cantante 2"));
    listaDeReproduccion.Agregar(new Cancion("Canción 3", "Cantante 3"));
    listaDeReproduccion.Agregar(new Cancion("Canción 4", "Cantante 4"));

    foreach (var cancion in listaDeReproduccion)
    {
        Console.WriteLine($"- {cancion.Titulo} — {cancion.Artista}");
    }
}

void EjemploConPatronPersonalizado()
{
    var listaDeReproduccion = new ListaDeReproduccion();
    listaDeReproduccion.Agregar(new Cancion("Canción 1", "Cantante 1"));
    listaDeReproduccion.Agregar(new Cancion("Canción 2", "Cantante 2"));
    listaDeReproduccion.Agregar(new Cancion("Canción 3", "Cantante 3"));
    listaDeReproduccion.Agregar(new Cancion("Canción 4", "Cantante 4"));

    // 1) Iteración por defecto
    Console.WriteLine("---- Adelante ----");
    MostrarEnConsola(listaDeReproduccion.CrearIterador());

    // 2) Iteración inversa
    Console.WriteLine();
    Console.WriteLine("---- Reversa ----");
    MostrarEnConsola(listaDeReproduccion.CrearIterador(ModoIteracion.Reversa));

    // 3) Iteración aleatoria
    Console.WriteLine();
    Console.WriteLine("---- Aleatorio ---");
    MostrarEnConsola(listaDeReproduccion.CrearIterador(ModoIteracion.Aleatorio));
}