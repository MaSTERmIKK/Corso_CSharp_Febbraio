using System;

class Program
{
    static void Main()
    {
        // =====================================
        // 4. SOMMA TRA INTERO E FLOAT
        // =====================================

        // Richiesta numero intero
        Console.Write("Inserisci un numero intero: ");
        int numeroIntero = int.Parse(Console.ReadLine());

        // Richiesta numero con virgola
        Console.Write("Inserisci un numero decimale: ");
        float numeroFloat = float.Parse(Console.ReadLine());

        // Casting dell'intero a float per fare la somma
        float somma = (float)numeroIntero + numeroFloat;

        Console.WriteLine("Somma: " + somma);


        // =====================================
        // 5. ETA' E ALTEZZA CON CASTING
        // =====================================

        // Richiesta età
        Console.Write("Inserisci la tua età: ");
        int eta = int.Parse(Console.ReadLine());

        // Richiesta altezza in metri
        Console.Write("Inserisci la tua altezza in metri: ");
        float altezza = float.Parse(Console.ReadLine());

        // Casting dell'altezza da float a int
        int altezzaConvertita = (int)altezza;

        // Somma tra età e altezza convertita
        int risultato = eta + altezzaConvertita;

        Console.WriteLine("Somma tra età e altezza convertita: " + risultato);
    }
}
