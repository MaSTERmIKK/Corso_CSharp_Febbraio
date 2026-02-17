using System;

class Program
{
    static void Main()
    {
        // =====================================
        // 1) IF SEMPLICE
        // =====================================

        int numero = 10;

        if (numero > 5)
        {
            Console.WriteLine("Il numero è maggiore di 5");
        }


        // =====================================
        // 2) IF - ELSE
        // =====================================

        int eta = 16;

        if (eta >= 18)
        {
            Console.WriteLine("Sei maggiorenne");
        }
        else
        {
            Console.WriteLine("Sei minorenne");
        }


        // =====================================
        // 3) IF - ELSE IF - ELSE
        // =====================================

        int voto = 75;

        if (voto >= 90)
        {
            Console.WriteLine("Ottimo");
        }
        else if (voto >= 70)
        {
            Console.WriteLine("Buono");
        }
        else if (voto >= 60)
        {
            Console.WriteLine("Sufficiente");
        }
        else
        {
            Console.WriteLine("Insufficiente");
        }


        // =====================================
        // 4) CONDIZIONI CON OPERATORI LOGICI
        // =====================================

        int a = 10;
        int b = 20;

        if (a > 5 && b > 15)
        {
            Console.WriteLine("Entrambe le condizioni sono vere");
        }

        if (a > 100 || b > 15)
        {
            Console.WriteLine("Almeno una condizione è vera");
        }

        if (!(a > 20))
        {
            Console.WriteLine("La condizione è negata con NOT");
        }


        // =====================================
        // 5) CONDIZIONI ANNIDATE
        // =====================================

        int temperatura = 30;

        if (temperatura > 20)
        {
            if (temperatura > 28)
            {
                Console.WriteLine("Fa molto caldo");
            }
            else
            {
                Console.WriteLine("Fa caldo");
            }
        }


        // =====================================
        // 6) OPERATORE TERNARIO
        // =====================================

        int numero2 = 8;

        string risultato = (numero2 % 2 == 0) ? "Pari" : "Dispari";

        Console.WriteLine("Il numero è: " + risultato);


        // =====================================
        // 7) SWITCH
        // =====================================

        int giorno = 3;

        switch (giorno)
        {
            case 1:
                Console.WriteLine("Lunedì");
                break;

            case 2:
                Console.WriteLine("Martedì");
                break;

            case 3:
                Console.WriteLine("Mercoledì");
                break;

            default:
                Console.WriteLine("Altro giorno");
                break;
        }
    }
}
