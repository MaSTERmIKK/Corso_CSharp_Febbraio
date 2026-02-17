using System;

class Program
{
    static void Main()
    {
        // =====================================
        // 1. CONTROLLO ETA' (MAGGIORENNE / MINORENNE)
        // =====================================

        // Costante per maggiore età
        const int MAGGIORE_ETA = 18;

        // Input età
        Console.Write("Inserisci la tua età: ");
        string inputEta = Console.ReadLine();

        // Casting esplicito (conversione string -> int)
        int eta = int.Parse(inputEta);

        // Controllo con IF
        if (eta >= MAGGIORE_ETA)
        {
            Console.WriteLine("Sei maggiorenne.");
        }
        else
        {
            Console.WriteLine("Sei minorenne.");
        }


        // =====================================
        // 2. PREZZO CON SCONTO DEL 10%
        // =====================================

        // Costante sconto
        const double SCONTO = 0.10;

        // Input prezzo
        Console.Write("Inserisci il prezzo del prodotto: ");
        string inputPrezzo = Console.ReadLine();

        // Conversione esplicita
        double prezzo = double.Parse(inputPrezzo);

        double prezzoFinale = prezzo;

        // Applicazione sconto solo se > 100
        if (prezzo > 100)
        {
            prezzoFinale = prezzo - (prezzo * SCONTO);
        }

        // Stampa con formattazione
        Console.WriteLine($"Prezzo finale: {prezzoFinale:F2} €");
    }
}
