using System;

class Program
{
    static void Main()
    {
        // =====================================
        // CREAZIONE OGGETTI DERIVATI
        // =====================================

        Cane cane = new Cane("Fido", 3);
        Gatto gatto = new Gatto("Micio", 2);

        // Uso metodi
        cane.Saluta();
        cane.Verso();

        gatto.Saluta();
        gatto.Verso();


        // =====================================
        // POLIMORFISMO CON TIPO BASE
        // =====================================

        Console.WriteLine("\n=== POLIMORFISMO ===");

        Animale[] animali = new Animale[2];

        animali[0] = cane;
        animali[1] = gatto;

        foreach (Animale animale in animali)
        {
            animale.Saluta();
            animale.Verso();  // Metodo ridefinito
        }
    }
}


// =====================================
// CLASSE BASE
// =====================================

class Animale
{
    protected string nome;
    protected int eta;

    // Costruttore
    public Animale(string nome, int eta)
    {
        this.nome = nome;
        this.eta = eta;
    }

    // Metodo normale
    public void Saluta()
    {
        Console.WriteLine("Sono " + nome + " e ho " + eta + " anni.");
    }

    // Metodo virtual (può essere sovrascritto)
    public virtual void Verso()
    {
        Console.WriteLine("Faccio un verso generico.");
    }
}


// =====================================
// CLASSE DERIVATA 1
// =====================================

class Cane : Animale
{
    // Costruttore che richiama quello della classe base
    public Cane(string nome, int eta) : base(nome, eta)
    {
    }

    // Override del metodo
    public override void Verso()
    {
        Console.WriteLine("Bau!");
    }
}


// =====================================
// CLASSE DERIVATA 2
// =====================================

class Gatto : Animale
{
    public Gatto(string nome, int eta) : base(nome, eta)
    {
    }

    public override void Verso()
    {
        Console.WriteLine("Miao!");
    }
}
