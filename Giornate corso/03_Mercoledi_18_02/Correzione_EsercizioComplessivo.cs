using System;

class Program
{
    static void Main()
    {
        // Variabili per registrazione
        string nomeRegistrato = "";
        string passwordRegistrata = "";

        bool programmaAttivo = true;

        while (programmaAttivo)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Registrazione");
            Console.WriteLine("2 - Login");
            Console.WriteLine("3 - Esci");
            Console.Write("Scelta: ");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    // REGISTRAZIONE
                    Console.Write("Inserisci nome: ");
                    nomeRegistrato = Console.ReadLine();

                    Console.Write("Inserisci password: ");
                    passwordRegistrata = Console.ReadLine();

                    Console.WriteLine("Registrazione completata!");
                    break;

                case 2:
                    // LOGIN
                    Console.Write("Inserisci nome: ");
                    string nomeLogin = Console.ReadLine();

                    Console.Write("Inserisci password: ");
                    string passwordLogin = Console.ReadLine();

                    if (nomeLogin == nomeRegistrato && passwordLogin == passwordRegistrata)
                    {
                        Console.WriteLine("Accesso consentito!");

                        // FOR conto alla rovescia
                        for (int i = 5; i >= 1; i--)
                        {
                            Console.WriteLine("Conto alla rovescia: " + i);
                        }

                        Console.WriteLine("Accesso completato!");
                    }
                    else
                    {
                        Console.WriteLine("Accesso negato!");
                    }

                    break;

                case 3:
                    programmaAttivo = false;
                    Console.WriteLine("Programma terminato.");
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}
