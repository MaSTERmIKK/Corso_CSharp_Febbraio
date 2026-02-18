using System;

class Program
{
    static void Main()
    {
        // =====================================
        // 1) CICLO WHILE
        // =====================================

        Console.WriteLine("=== WHILE ===");

        int contatore = 1;

        while (contatore <= 5)
        {
            Console.WriteLine("Numero: " + contatore);
            contatore++; // Incremento per evitare loop infinito
        }


        // =====================================
        // 2) CICLO DO-WHILE
        // =====================================

        Console.WriteLine("\n=== DO-WHILE ===");

        int numero = 1;

        do
        {
            Console.WriteLine("Valore: " + numero);
            numero++;
        }
        while (numero <= 5);


        // =====================================
        // 3) CICLO FOR
        // =====================================

        Console.WriteLine("\n=== FOR ===");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("i: " + i);
        }


        // =====================================
        // 4) FOREACH (con array semplice)
        // =====================================

        Console.WriteLine("\n=== FOREACH ===");

        int[] numeri = { 10, 20, 30, 40 };

        foreach (int n in numeri)
        {
            Console.WriteLine("Elemento: " + n);
        }


        // =====================================
        // 5) BREAK
        // =====================================

        Console.WriteLine("\n=== BREAK ===");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break; // Interrompe il ciclo
            }

            Console.WriteLine("i: " + i);
        }


        // =====================================
        // 6) CONTINUE
        // =====================================

        Console.WriteLine("\n=== CONTINUE ===");

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue; // Salta il 3
            }

            Console.WriteLine("i: " + i);
        }


        // =====================================
        // 7) CICLI ANNIDATI
        // =====================================

        Console.WriteLine("\n=== CICLI ANNIDATI ===");

        for (int riga = 1; riga <= 3; riga++)
        {
            for (int colonna = 1; colonna <= 3; colonna++)
            {
                Console.Write(colonna + " ");
            }

            Console.WriteLine(); // Va a capo
        }
    }
}
