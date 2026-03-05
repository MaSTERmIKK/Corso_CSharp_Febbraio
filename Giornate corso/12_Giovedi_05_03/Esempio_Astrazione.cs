using System;

class Program
{
    static void Main()
    {
        // =====================================
        // OGGETTI
        // =====================================

        Veicolo auto = new Auto("Fiat");
        Veicolo moto = new Moto("Yamaha");

        // =====================================
        // POLIMORFISMO CON CLASSE ASTRATTA
        // =====================================

        Veicolo[] veicoli = { auto, moto };

        Console.WriteLine("=== USO CLASSE ASTRATTA ===\n");

        foreach (Veicolo v in veicoli)
        {
            v.MostraMarca();
            v.Avvia();
            Console.WriteLine();
        }


        // =====================================
        // POLIMORFISMO CON INTERFACCIA
        // =====================================

        Console.WriteLine("=== USO INTERFACCIA ===\n");

        IManutenzione[] servizi = { (Auto)auto, (Moto)moto };

        foreach (IManutenzione servizio in servizi)
        {
            servizio.FaiManutenzione();
        }
    }
}


// =====================================
// INTERFACCIA
// =====================================

interface IManutenzione
{
    void FaiManutenzione();
}


// =====================================
// CLASSE ASTRATTA
// =====================================

abstract class Veicolo
{
    protected string marca;

    public Veicolo(string marca)
    {
        this.marca = marca;
    }

    // Metodo concreto
    public void MostraMarca()
    {
        Console.WriteLine("Marca: " + marca);
    }

    // Metodo astratto
    public abstract void Avvia();
}


// =====================================
// CLASSE DERIVATA 1
// =====================================

class Auto : Veicolo, IManutenzione
{
    public Auto(string marca) : base(marca)
    {
    }

    public override void Avvia()
    {
        Console.WriteLine("L'auto si avvia con la chiave.");
    }

    // Implementazione interfaccia
    public void FaiManutenzione()
    {
        Console.WriteLine("Manutenzione auto: controllo olio.");
    }
}


// =====================================
// CLASSE DERIVATA 2
// =====================================

class Moto : Veicolo, IManutenzione
{
    public Moto(string marca) : base(marca)
    {
    }

    public override void Avvia()
    {
        Console.WriteLine("La moto si avvia con il pulsante.");
    }

    // Implementazione interfaccia
    public void FaiManutenzione()
    {
        Console.WriteLine("Manutenzione moto: controllo catena.");
    }
}

