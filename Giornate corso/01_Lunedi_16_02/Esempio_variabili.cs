using System;

class Program
{
    static void Main()
    {
        // ==============================
        // 1) DICHIARAZIONE E INIZIALIZZAZIONE
        // ==============================

        int numero;          // Dichiarazione
        numero = 10;         // Inizializzazione

        double prezzo = 19.99; // Dichiarazione + inizializzazione

        Console.WriteLine("Numero: " + numero);
        Console.WriteLine("Prezzo: " + prezzo);


        // ==============================
        // 2) INFERENZA CON VAR
        // ==============================

        var eta = 25;            // int
        var nome = "Mirko";      // string
        var altezza = 1.75;      // double

        Console.WriteLine("Eta: " + eta);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Altezza: " + altezza);


        // ==============================
        // 3) COSTANTI (CONST)
        // ==============================

        const double PI = 3.14159;  // Non modificabile

        double raggio = 5;
        double area = PI * raggio * raggio;

        Console.WriteLine("Area cerchio: " + area);


        // ==============================
        // 4) OPERAZIONI ARITMETICHE
        // ==============================

        int a = 10;
        int b = 3;

        int somma = a + b;
        int differenza = a - b;
        int prodotto = a * b;
        int divisione = a / b;     // Divisione intera
        int resto = a % b;         // Modulo

        Console.WriteLine("Somma: " + somma);
        Console.WriteLine("Differenza: " + differenza);
        Console.WriteLine("Prodotto: " + prodotto);
        Console.WriteLine("Divisione intera: " + divisione);
        Console.WriteLine("Resto: " + resto);


        // ==============================
        // 5) CONCATENAZIONE STRINGHE
        // ==============================

        string cognome = "Campari";
        string nomeCompleto = nome + " " + cognome;

        Console.WriteLine("Nome completo: " + nomeCompleto);


        // ==============================
        // 6) INTERPOLAZIONE DI STRINGHE
        // ==============================

        Console.WriteLine($"Interpolazione -> Nome: {nome}, Eta: {eta}");


        // ==============================
        // 7) CASTING ESPLICITO
        // ==============================

        double valoreDouble = 9.78;
        int valoreIntero = (int)valoreDouble;  // Perde la parte decimale

        Console.WriteLine("Double originale: " + valoreDouble);
        Console.WriteLine("Dopo cast a int: " + valoreIntero);


        // ==============================
        // 8) CONVERSIONE TRA TIPI
        // ==============================

        string numeroStringa = "100";
        int numeroConvertito = Convert.ToInt32(numeroStringa);

        Console.WriteLine("Numero convertito da stringa: " + numeroConvertito);


        // ==============================
        // 9) INCREMENTO E DECREMENTO
        // ==============================

        int contatore = 0;

        contatore++;   // Incremento
        contatore += 5; // Incremento composto
        contatore--;   // Decremento

        Console.WriteLine("Valore contatore: " + contatore);


        // ==============================
        // 10) VARIABILI BOOLEANE
        // ==============================

        bool maggiore = a > b;

        Console.WriteLine("a è maggiore di b? " + maggiore);


        // ==============================
        // 11) INPUT DA UTENTE
        // ==============================

        Console.Write("Inserisci un numero: ");
        string input = Console.ReadLine();  // Legge stringa

        int numeroUtente = Convert.ToInt32(input);  // Conversione

        Console.WriteLine("Hai inserito: " + numeroUtente);
    }
}
