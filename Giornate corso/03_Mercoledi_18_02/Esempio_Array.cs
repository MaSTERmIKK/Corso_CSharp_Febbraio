using System;

class Program
{
    static void Main()
    {
        // =====================================
        // 1) DICHIARAZIONE ARRAY
        // =====================================

        int[] numeri;          // Solo dichiarazione

        numeri = new int[5];   // Array di 5 elementi (inizializzati a 0)


        // =====================================
        // 2) ASSEGNAZIONE VALORI
        // =====================================

        numeri[0] = 10;
        numeri[1] = 20;
        numeri[2] = 30;
        numeri[3] = 40;
        numeri[4] = 50;

        Console.WriteLine("Primo elemento: " + numeri[0]);
        Console.WriteLine("Ultimo elemento: " + numeri[4]);


        // =====================================
        // 3) INIZIALIZZAZIONE DIRETTA
        // =====================================

        int[] valori = { 5, 15, 25, 35 };

        Console.WriteLine("\nElementi array valori:");

        for (int i = 0; i < valori.Length; i++)
        {
            Console.WriteLine("Indice " + i + ": " + valori[i]);
        }


        // =====================================
        // 4) MODIFICA ELEMENTO
        // =====================================

        valori[2] = 100;

        Console.WriteLine("\nElemento modificato (indice 2): " + valori[2]);


        // =====================================
        // 5) FOREACH
        // =====================================

        Console.WriteLine("\nStampa con foreach:");

        foreach (int numero in valori)
        {
            Console.WriteLine(numero);
        }


        // =====================================
        // 6) SOMMA ELEMENTI ARRAY
        // =====================================

        int somma = 0;

        for (int i = 0; i < valori.Length; i++)
        {
            somma += valori[i];
        }

        Console.WriteLine("\nSomma totale: " + somma);


        // =====================================
        // 7) RICERCA DI UN VALORE
        // =====================================

        int cercato = 100;
        bool trovato = false;

        for (int i = 0; i < valori.Length; i++)
        {
            if (valori[i] == cercato)
            {
                trovato = true;
                break;
            }
        }

        Console.WriteLine("Valore trovato? " + trovato);


        // =====================================
        // 8) ARRAY BIDIMENSIONALE
        // =====================================

        Console.WriteLine("\nArray bidimensionale:");

        int[,] matrice =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        for (int riga = 0; riga < 3; riga++)
        {
            for (int colonna = 0; colonna < 3; colonna++)
            {
                Console.Write(matrice[riga, colonna] + " ");
            }
            Console.WriteLine();
        }
    }
}
