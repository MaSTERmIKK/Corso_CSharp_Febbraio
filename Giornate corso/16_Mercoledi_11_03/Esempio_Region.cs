using System;

class Program
{
    static void Main()
    {

        #region Variabili
        // ==========================================
        // Le region servono per raggruppare porzioni
        // di codice logicamente correlate.
        // In molti IDE possono essere chiuse/apert e
        // per rendere il codice più leggibile.
        // ==========================================

        int a = 10;
        int b = 5;

        #endregion


        #region Operazioni
        // ==========================================
        // Qui possiamo mettere una sezione dedicata
        // alla logica di calcolo o alle operazioni
        // principali del programma.
        // ==========================================

        int somma = a + b;
        int differenza = a - b;

        Console.WriteLine("Somma: " + somma);
        Console.WriteLine("Differenza: " + differenza);

        #endregion


        #region Condizioni
        // ==========================================
        // Le region possono aiutare a separare
        // le diverse logiche del programma
        // (condizioni, cicli, gestione input ecc.)
        // ==========================================

        if (somma > 10)
        {
            Console.WriteLine("La somma è maggiore di 10");
        }

        #endregion


        #region Cicli
        // ==========================================
        // Esempio di region per raggruppare i cicli
        // ==========================================

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Iterazione: " + i);
        }

        #endregion


        #region FineProgramma
        // ==========================================
        // Ultima sezione del programma
        // ==========================================

        Console.WriteLine("Fine programma");

        #endregion

    }
}
