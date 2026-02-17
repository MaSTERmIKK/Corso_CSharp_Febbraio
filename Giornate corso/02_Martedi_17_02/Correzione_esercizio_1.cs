using System;

class Program
{
    static void Main()
    {
        // ==============================
        // 1. SOMMA DI DUE NUMERI
        // ==============================

        // Dichiarazione di due variabili intere
        int numero1 = 10;
        int numero2 = 5;

        // Somma tramite operatore +
        int somma = numero1 + numero2;

        // Stampa del risultato
        Console.WriteLine("Somma: " + somma);


        // ==============================
        // 2. CALCOLO DI UN PREZZO SCONTATO
        // ==============================

        // Prezzo originale
        double prezzoOriginale = 100.0;

        // Calcolo dello sconto del 20%
        double sconto = prezzoOriginale * 20 / 100;

        // Prezzo finale
        double prezzoFinale = prezzoOriginale - sconto;

        Console.WriteLine("Prezzo finale scontato: " + prezzoFinale);


        // ==============================
        // 3. CONTROLLO NUMERO POSITIVO
        // ==============================

        // Variabile float
        float numero = -3.5f;

        // Espressione booleana (operatore di confronto)
        bool ePositivo = numero > 0;

        Console.WriteLine("Il numero è positivo? " + ePositivo);


        // ==============================
        // ESEMPIO DI CASTING SEMPLICE
        // ==============================

        double valoreDouble = 9.8;

        // Casting esplicito da double a int
        int valoreIntero = (int)valoreDouble;

        Console.WriteLine("Casting da double a int: " + valoreIntero);
    }
}
