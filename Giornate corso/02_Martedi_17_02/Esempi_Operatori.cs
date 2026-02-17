using System;

class Program
{
    static void Main()
    {
        // =====================================
        // 1) OPERATORI ARITMETICI
        // =====================================

        int a = 10;
        int b = 3;

        Console.WriteLine("=== OPERATORI ARITMETICI ===");

        Console.WriteLine("Somma: " + (a + b));        // +
        Console.WriteLine("Differenza: " + (a - b));  // -
        Console.WriteLine("Prodotto: " + (a * b));    // *
        Console.WriteLine("Divisione: " + (a / b));   // / (intera)
        Console.WriteLine("Resto: " + (a % b));       // %


        // =====================================
        // 2) OPERATORI DI CONFRONTO
        // =====================================

        Console.WriteLine("\n=== OPERATORI DI CONFRONTO ===");

        Console.WriteLine("a == b : " + (a == b));   // Uguale
        Console.WriteLine("a != b : " + (a != b));   // Diverso
        Console.WriteLine("a > b  : " + (a > b));    // Maggiore
        Console.WriteLine("a < b  : " + (a < b));    // Minore
        Console.WriteLine("a >= b : " + (a >= b));   // Maggiore o uguale
        Console.WriteLine("a <= b : " + (a <= b));   // Minore o uguale


        // =====================================
        // 3) OPERATORI LOGICI
        // =====================================

        Console.WriteLine("\n=== OPERATORI LOGICI ===");

        bool condizione1 = a > 5;
        bool condizione2 = b < 5;

        Console.WriteLine("Condizione1 (a > 5): " + condizione1);
        Console.WriteLine("Condizione2 (b < 5): " + condizione2);

        Console.WriteLine("AND (&&): " + (condizione1 && condizione2)); // entrambe vere
        Console.WriteLine("OR (||): " + (condizione1 || condizione2));  // almeno una vera
        Console.WriteLine("NOT (!): " + (!condizione1));                // negazione


        // =====================================
        // 4) OPERATORI DI ASSEGNAZIONE
        // =====================================

        Console.WriteLine("\n=== OPERATORI DI ASSEGNAZIONE ===");

        int numero = 10;

        numero += 5;   // numero = numero + 5
        Console.WriteLine("+= 5 : " + numero);

        numero -= 3;   // numero = numero - 3
        Console.WriteLine("-= 3 : " + numero);

        numero *= 2;   // numero = numero * 2
        Console.WriteLine("*= 2 : " + numero);

        numero /= 4;   // numero = numero / 4
        Console.WriteLine("/= 4 : " + numero);

        numero %= 3;   // numero = numero % 3
        Console.WriteLine("%= 3 : " + numero);


        // =====================================
        // 5) INCREMENTO E DECREMENTO
        // =====================================

        Console.WriteLine("\n=== INCREMENTO / DECREMENTO ===");

        int contatore = 5;

        Console.WriteLine("Valore iniziale: " + contatore);

        contatore++;  // post-incremento
        Console.WriteLine("Dopo contatore++ : " + contatore);

        contatore--;  // post-decremento
        Console.WriteLine("Dopo contatore-- : " + contatore);

        ++contatore;  // pre-incremento
        Console.WriteLine("Dopo ++contatore : " + contatore);

        --contatore;  // pre-decremento
        Console.WriteLine("Dopo --contatore : " + contatore);


        // =====================================
        // 6) ESEMPIO COMBINATO
        // =====================================

        Console.WriteLine("\n=== ESEMPIO COMBINATO ===");

        int x = 20;
        int y = 15;

        bool risultato = (x > y) && (x % 2 == 0);

        Console.WriteLine("x > y AND x è pari ? " + risultato);
    }
}
