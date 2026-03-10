using System;
using System.Collections.Generic;

// ------------------------------
// SINGLETON
// Classe che gestisce le configurazioni di sistema
// ------------------------------
public sealed class ConfigurazioneSistema
{
    // Istanza unica della classe (Singleton)
    private static ConfigurazioneSistema istanza;

    // Dizionario che contiene coppie chiave-valore delle configurazioni
    private Dictionary<string, string> configurazioni;

    // Costruttore privato per impedire creazione diretta dell'oggetto
    private ConfigurazioneSistema()
    {
        configurazioni = new Dictionary<string, string>();
    }

    // Metodo statico che restituisce l'unica istanza della classe
    public static ConfigurazioneSistema GetInstance()
    {
        // Se l'istanza non esiste la crea
        if (istanza == null)
        {
            istanza = new ConfigurazioneSistema();
        }

        return istanza;
    }

    // Metodo per impostare o aggiornare una configurazione
    public void Imposta(string chiave, string valore)
    {
        configurazioni[chiave] = valore;
    }

    // Metodo per leggere una configurazione
    public string Leggi(string chiave)
    {
        if (configurazioni.ContainsKey(chiave))
        {
            return configurazioni[chiave];
        }
        else
        {
            return "Configurazione non trovata";
        }
    }

    // Metodo che stampa tutte le configurazioni salvate
    public void StampaTutte()
    {
        Console.WriteLine("\nConfigurazioni salvate:");

        foreach (var conf in configurazioni)
        {
            Console.WriteLine(conf.Key + " = " + conf.Value);
        }
    }
}


// ------------------------------
// INTERFACCIA DISPOSITIVO
// ------------------------------
public interface IDispositivo
{
    void Avvia();
    void MostraTipo();
}


// ------------------------------
// CLASSE COMPUTER
// ------------------------------
public class Computer : IDispositivo
{
    public void Avvia()
    {
        Console.WriteLine("Il computer si avvia...");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Computer");
    }
}


// ------------------------------
// CLASSE STAMPANTE
// ------------------------------
public class Stampante : IDispositivo
{
    public void Avvia()
    {
        Console.WriteLine("La stampante si accende...");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Stampante");
    }
}


// ------------------------------
// FACTORY
// Classe che crea dispositivi
// ------------------------------
public class DispositivoFactory
{
    public static IDispositivo CreaDispositivo(string tipo)
    {
        if (tipo.ToLower() == "computer")
        {
            return new Computer();
        }
        else if (tipo.ToLower() == "stampante")
        {
            return new Stampante();
        }
        else
        {
            return null;
        }
    }
}


// ------------------------------
// PROGRAMMA PRINCIPALE
// ------------------------------
class Program
{
    static void Main(string[] args)
    {
        // Recupera l'istanza unica del sistema di configurazione
        ConfigurazioneSistema config = ConfigurazioneSistema.GetInstance();

        // Lista dispositivi creati
        List<IDispositivo> dispositivi = new List<IDispositivo>();

        int scelta = 0;

        // Menu principale
        do
        {
            Console.WriteLine("\n=== MENU SISTEMA ===");
            Console.WriteLine("1 - Aggiungi configurazione");
            Console.WriteLine("2 - Leggi configurazione");
            Console.WriteLine("3 - Mostra tutte le configurazioni");
            Console.WriteLine("4 - Crea dispositivo");
            Console.WriteLine("5 - Avvia dispositivi");
            Console.WriteLine("0 - Esci");

            Console.Write("Scelta: ");
            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    // Inserimento configurazione
                    Console.Write("Chiave: ");
                    string chiave = Console.ReadLine();

                    Console.Write("Valore: ");
                    string valore = Console.ReadLine();

                    config.Imposta(chiave, valore);

                    Console.WriteLine("Configurazione salvata!");
                    break;

                case 2:
                    // Lettura configurazione
                    Console.Write("Inserisci chiave: ");
                    string cerca = Console.ReadLine();

                    Console.WriteLine(config.Leggi(cerca));
                    break;

                case 3:
                    // Stampa tutte le configurazioni
                    config.StampaTutte();
                    break;

                case 4:
                    // Creazione dispositivo tramite factory
                    Console.Write("Tipo dispositivo (computer/stampante): ");
                    string tipo = Console.ReadLine();

                    IDispositivo disp = DispositivoFactory.CreaDispositivo(tipo);

                    if (disp != null)
                    {
                        dispositivi.Add(disp);
                        Console.WriteLine("Dispositivo creato!");
                    }
                    else
                    {
                        Console.WriteLine("Tipo non valido.");
                    }

                    break;

                case 5:
                    // Avvio dispositivi
                    foreach (IDispositivo d in dispositivi)
                    {
                        d.MostraTipo();
                        d.Avvia();
                    }
                    break;

                case 0:
                    Console.WriteLine("Uscita dal programma...");
                    break;

                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }

        } while (scelta != 0);
    }
}

