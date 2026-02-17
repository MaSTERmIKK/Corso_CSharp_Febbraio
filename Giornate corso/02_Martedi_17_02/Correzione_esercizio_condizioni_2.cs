using System;

class Program
{
    static void Main()
    {
        // =====================================
        // 1. NUMERO PARI O DISPARI
        // =====================================

        Console.Write("Inserisci un numero intero: ");
        string inputNumero = Console.ReadLine();

        // Conversione esplicita string -> int
        int numero = int.Parse(inputNumero);

        // Uso del modulo %
        if (numero % 2 == 0)
        {
            Console.WriteLine("Il numero è PARI.");
        }
        else
        {
            Console.WriteLine("Il numero è DISPARI.");
        }


        // =====================================
        // 2. CONTROLLO PASSWORD NUMERICA
        // =====================================

        // Costante password
        const int PASSWORD_CORRETTA = 1234;

        Console.Write("Inserisci la password numerica: ");
        string inputPassword = Console.ReadLine();

        // Conversione esplicita
        int passwordInserita = int.Parse(inputPassword);

        // Controllo con if-else
        if (passwordInserita == PASSWORD_CORRETTA)
        {
            Console.WriteLine("Accesso consentito.");
        }
        else
        {
            Console.WriteLine("Accesso negato.");
        }
    }
}
