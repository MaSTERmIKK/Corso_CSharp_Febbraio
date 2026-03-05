using System;

class Program
{
    static void Main()
    {
        // =====================================
        // CREAZIONE OGGETTI DERIVATI
        // =====================================

        Veicolo auto = new Auto("Fiat");
        Veicolo moto = new Moto("Yamaha");

        // =====================================
        // POLIMORFISMO CON TIPO ASTRATTO
        // =====================================

        Veicolo[] veicoli = { auto, moto };

        foreach (Veicolo v in veicoli)
        {
            v.MostraMarca();  // metodo concreto della classe base
            v.Avvia();        // metodo astratto implementato nelle classi figlie
            Console.WriteLine();
        }
    }
}


// =====================================
// CLASSE ASTRATTA
// =====================================

abstract class Veicolo
{
    protected string marca;

    // Costruttore
    public Veicolo(string marca)
    {
        this.marca = marca;
    }

    // Metodo concreto (già implementato)
    public void MostraMarca()
    {
        Console.WriteLine("Marca: " + marca);
    }

    // Metodo astratto (DEVE essere implementato nelle classi figlie)
    public abstract void Avvia();
}


// =====================================
// CLASSE DERIVATA 1
// =====================================

class Auto : Veicolo
{
    public Auto(string marca) : base(marca)
    {
    }

    // Implementazione del metodo astratto
    public override void Avvia()
    {
        Console.WriteLine("L'auto si avvia con la chiave.");
    }
}


// =====================================
// CLASSE DERIVATA 2
// =====================================

class Moto : Veicolo
{
    public Moto(string marca) : base(marca)
    {
    }

    // Implementazione del metodo astratto
    public override void Avvia()
    {
        Console.WriteLine("La moto si avvia con il pulsante.");
    }
}
