using System;

class Program
{
    static void Main()
    {
        // =====================================
        // CREAZIONE OGGETTO
        // =====================================

        ContoBancario conto = new ContoBancario("Mirko", 1000);

        // Accesso tramite metodi pubblici
        Console.WriteLine("Intestatario: " + conto.GetIntestatario());
        Console.WriteLine("Saldo iniziale: " + conto.GetSaldo());

        // Deposito valido
        conto.Deposita(500);
        Console.WriteLine("Saldo dopo deposito: " + conto.GetSaldo());

        // Tentativo di prelievo valido
        conto.Preleva(300);
        Console.WriteLine("Saldo dopo prelievo: " + conto.GetSaldo());

        // Tentativo di operazione NON valida
        conto.Preleva(5000);   // Non deve essere permesso

        // =====================================
        // USO PROPRIETA'
        // =====================================

        Console.WriteLine("\n=== PROPRIETA' ===");

        conto.Intestatario = "Marco";  // Usa il setter
        Console.WriteLine("Nuovo intestatario: " + conto.Intestatario);
    }
}


// =====================================
// CLASSE CON INCAPSULAMENTO
// =====================================

class ContoBancario
{
    // Attributi privati (NON accessibili direttamente dall'esterno)
    private string intestatario;
    private double saldo;

    // Costruttore
    public ContoBancario(string intestatario, double saldoIniziale)
    {
        this.intestatario = intestatario;

        if (saldoIniziale >= 0)
        {
            saldo = saldoIniziale;
        }
        else
        {
            saldo = 0;
        }
    }

    // =====================================
    // GETTER MANUALI
    // =====================================

    public string GetIntestatario()
    {
        return intestatario;
    }

    public double GetSaldo()
    {
        return saldo;
    }

    // =====================================
    // METODI CHE PROTEGGONO LO STATO
    // =====================================

    public void Deposita(double importo)
    {
        if (importo > 0)
        {
            saldo += importo;
        }
        else
        {
            Console.WriteLine("Importo non valido.");
        }
    }

    public void Preleva(double importo)
    {
        if (importo > 0 && importo <= saldo)
        {
            saldo -= importo;
        }
        else
        {
            Console.WriteLine("Prelievo non consentito.");
        }
    }

    // =====================================
    // PROPRIETA' (GET/SET)
    // =====================================

    public string Intestatario
    {
        get { return intestatario; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                intestatario = value;
            }
        }
    }
}
