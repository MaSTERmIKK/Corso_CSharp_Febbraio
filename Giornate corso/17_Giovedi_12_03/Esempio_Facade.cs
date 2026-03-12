using System;

// Sottosistema 1: gestione della TV
public class TV
{
    // Accende la TV
    public void TurnOn()
    {
        Console.WriteLine("TV accesa.");
    }

    // Spegne la TV
    public void TurnOff()
    {
        Console.WriteLine("TV spenta.");
    }
}

// Sottosistema 2: gestione dell'audio
public class AudioSystem
{
    // Accende l'impianto audio
    public void TurnOn()
    {
        Console.WriteLine("Sistema audio acceso.");
    }

    // Imposta il volume
    public void SetVolume(int level)
    {
        Console.WriteLine("Volume impostato a " + level + ".");
    }

    // Spegne l'impianto audio
    public void TurnOff()
    {
        Console.WriteLine("Sistema audio spento.");
    }
}

// Sottosistema 3: gestione delle luci
public class Lights
{
    // Abbassa l'intensità delle luci
    public void Dim()
    {
        Console.WriteLine("Luci abbassate.");
    }

    // Riporta le luci alla normalità
    public void Brighten()
    {
        Console.WriteLine("Luci riaccese normalmente.");
    }
}

// Facade: semplifica l'utilizzo del sistema Home Theater
public class HomeTheaterFacade
{
    // Riferimenti ai vari sottosistemi
    private TV _tv;
    private AudioSystem _audioSystem;
    private Lights _lights;

    // Costruttore: riceve i componenti del sistema
    public HomeTheaterFacade(TV tv, AudioSystem audioSystem, Lights lights)
    {
        _tv = tv;
        _audioSystem = audioSystem;
        _lights = lights;
    }

    // Metodo semplificato per avviare la visione di un film
    public void WatchMovie()
    {
        Console.WriteLine("Avvio modalità cinema...");
        _lights.Dim();              // Abbassa le luci
        _tv.TurnOn();               // Accende la TV
        _audioSystem.TurnOn();      // Accende l'audio
        _audioSystem.SetVolume(20); // Imposta il volume
    }

    // Metodo semplificato per terminare la visione
    public void EndMovie()
    {
        Console.WriteLine("Chiusura modalità cinema...");
        _audioSystem.TurnOff(); // Spegne l'audio
        _tv.TurnOff();          // Spegne la TV
        _lights.Brighten();     // Riporta le luci normali
    }
}

// Client
public class Program
{
    public static void Main()
    {
        // Creazione dei singoli sottosistemi
        TV tv = new TV();
        AudioSystem audio = new AudioSystem();
        Lights lights = new Lights();

        // Creazione della facade
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, audio, lights);

        // Il client usa solo la facade
        homeTheater.WatchMovie();

        Console.WriteLine();

        homeTheater.EndMovie();
    }
}
