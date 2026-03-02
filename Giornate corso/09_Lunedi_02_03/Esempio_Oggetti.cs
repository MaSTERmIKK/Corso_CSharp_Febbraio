using System;

class Program
{
    static void Main()
    {
        // =====================================
        // 1) CREAZIONE OGGETTI
        // =====================================

        Persona p1 = new Persona("Mirko", 30);
        Persona p2 = new Persona("Anna", 25);

        // Uso dei metodi
        p1.Saluta();
        p2.Saluta();

        Console.WriteLine("Eta di Mirko: " + p1.GetEta());


        // =====================================
        // 2) MODIFICA STATO OGGETTO
        // =====================================

        p1.Compleanno();  // Incrementa età

        Console.WriteLine("Nuova eta di Mirko: " + p1.GetEta());


        // =====================================
        // 3) ARRAY DI OGGETTI
        // =====================================

        Persona[] persone = new Persona[2];

        persone[0] = p1;
        persone[1] = p2;

        Console.WriteLine("\nLista persone:");

        foreach (Persona persona in persone)
        {
            persona.Saluta();
        }


        // =====================================
        // 4) METODO CON PARAMETRO
        // =====================================

        p1.CambiaNome("Marco");
        p1.Saluta();


        // =====================================
        // 5) METODO CHE RESTITUISCE VALORE
        // =====================================

        bool maggiorenne = p1.E_Maggiorenne();
        Console.WriteLine("E' maggiorenne? " + maggiorenne);
    }
}


// =====================================
// DEFINIZIONE CLASSE
// =====================================

class Persona
{
    // Attributi (stato dell'oggetto)
    private string nome;
    private int eta;

    // Costruttore
    public Persona(string nome, int eta)
    {
        this.nome = nome;
        this.eta = eta;
    }

    // Metodo che stampa un messaggio
    public void Saluta()
    {
        Console.WriteLine("Ciao, mi chiamo " + nome + " e ho " + eta + " anni.");
    }

    // Metodo che restituisce un valore
    public int GetEta()
    {
        return eta;
    }

    // Metodo che modifica lo stato
    public void Compleanno()
    {
        eta++;
    }

    // Metodo con parametro
    public void CambiaNome(string nuovoNome)
    {
        nome = nuovoNome;
    }

    // Metodo booleano
    public bool E_Maggiorenne()
    {
        return eta >= 18;
    }
}
