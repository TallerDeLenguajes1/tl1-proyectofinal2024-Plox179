public class FabricaDePersonaje
{
    public static Personaje CrearPersonaje()
    {
        Random numRand = new Random();
        int dia = numRand.Next(1,32);
        int mes = numRand.Next(1,13);
        int anio = numRand.Next(1800, 2025);
        Personaje miPersonaje = new Personaje();
        miPersonaje.Nombre = "...";
        miPersonaje.Apodo = "asd";
        miPersonaje.Armadura = numRand.Next(1,11);
        miPersonaje.Edad = numRand.Next(1,301);
        miPersonaje.FechaNac = new DateTime(dia,mes,anio);
        miPersonaje.Nivel = numRand.Next(1,11);
        miPersonaje.Tipo = "Guerrero";
        miPersonaje.Velocidad = numRand.Next(1,11);
        miPersonaje.Fuerza = numRand.Next(1,11);
        return miPersonaje;
    }
}
