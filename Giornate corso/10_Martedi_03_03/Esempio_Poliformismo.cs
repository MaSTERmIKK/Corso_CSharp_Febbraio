using System;

class Program
{
    static void Main()
    {
        // ==============================
        // 1) OVERLOAD DI METODI (stesso nome, parametri diversi)
        // ==============================
        Console.WriteLine("=== OVERLOAD METODI ===");

        Console.WriteLine(Calcolatore.Somma(5, 3));              // int, int
        Console.WriteLine(Calcolatore.Somma(5.5, 3.2));          // double, double
        Console.WriteLine(Calcolatore.Somma(1, 2, 3));           // int, int, int
        Console.WriteLine(Calcolatore.Somma("Ciao ", "Mirko"));  // string, string

        // Overload con parametri diversi (tipi + ordine)
        Calcolatore.Stampa(10);          // int
        Calcolatore.Stampa("Testo");     // string
        Calcolatore.Stampa(7, "pippo");  // int + string


        // ==============================
        // 2) "METODI POLIMORFICI" CON OVERLOAD (stesso nome, input diversi)
        // Esempio: sconto calcolato in modi diversi
        // ==============================
        Console.WriteLine("\n=== METODO POLIMORFICO (OVERLOAD) ===");

        double prezzoBase = 100;

        Console.WriteLine("Sconto %: " + Calcolatore.ApplicaSconto(prezzoBase, 10));     // percentuale
        Console.WriteLine("Sconto fisso: " + Calcolatore.ApplicaSconto(prezzoBase, 15.5)); // valore fisso
        Console.WriteLine("Sconto VIP: " + Calcolatore.ApplicaSconto(prezzoBase, true)); // vip sì/no


        // ==============================
        // 3) OVERLOAD DI OPERATORI
        // ==============================
        Console.WriteLine("\n=== OVERLOAD OPERATORI ===");

        Punto p1 = new Punto(2, 3);
        Punto p2 = new Punto(5, 1);

        // Operatore + (somma tra punti)
        Punto p3 = p1 + p2;
        Console.WriteLine("p1 + p2 = " + p3);

        // Operatore - (differenza tra punti)
        Punto p4 = p1 - p2;
        Console.WriteLine("p1 - p2 = " + p4);

        // Operatori == e != (uguaglianza tra punti)
        Console.WriteLine("p1 == p2 ? " + (p1 == p2));
        Console.WriteLine("p1 != p2 ? " + (p1 != p2));

        // Operatori > e < (confronto sulla distanza dall'origine)
        Console.WriteLine("p1 > p2 ? " + (p1 > p2));
        Console.WriteLine("p1 < p2 ? " + (p1 < p2));
    }
}


// =====================================
// CLASSE CON METODI OVERLOADED
// =====================================
static class Calcolatore
{
    // Overload: Somma di int
    public static int Somma(int a, int b)
    {
        return a + b;
    }

    // Overload: Somma di double
    public static double Somma(double a, double b)
    {
        return a + b;
    }

    // Overload: Somma di 3 int
    public static int Somma(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overload: "Somma" di stringhe = concatenazione
    public static string Somma(string a, string b)
    {
        return a + b;
    }

    // Overload: Stampa con firme diverse
    public static void Stampa(int x)
    {
        Console.WriteLine("Stampa int: " + x);
    }

    public static void Stampa(string s)
    {
        Console.WriteLine("Stampa string: " + s);
    }

    public static void Stampa(int x, string s)
    {
        Console.WriteLine("Stampa (int,string): " + x + " - " + s);
    }

    // =====================================
    // METODO "POLIMORFICO" (OVERLOAD) - stesso nome, diversi modi di calcolare
    // =====================================

    // Applica sconto percentuale (int percentuale)
    public static double ApplicaSconto(double prezzo, int percentuale)
    {
        return prezzo - (prezzo * percentuale / 100.0);
    }

    // Applica sconto fisso (double importo)
    public static double ApplicaSconto(double prezzo, double scontoFisso)
    {
        return prezzo - scontoFisso;
    }

    // Applica sconto VIP (bool)
    public static double ApplicaSconto(double prezzo, bool vip)
    {
        if (vip)
        {
            return prezzo * 0.8; // -20%
        }
        return prezzo; // nessuno sconto
    }
}


// =====================================
// CLASSE CON OVERLOAD DI OPERATORI
// =====================================
class Punto
{
    private int x;
    private int y;

    public Punto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // Per stampare facilmente
    public override string ToString()
    {
        return "(" + x + ", " + y + ")";
    }

    // Overload operatore +
    public static Punto operator +(Punto a, Punto b)
    {
        return new Punto(a.x + b.x, a.y + b.y);
    }

    // Overload operatore -
    public static Punto operator -(Punto a, Punto b)
    {
        return new Punto(a.x - b.x, a.y - b.y);
    }

    // Overload == e != (DEVONO essere in coppia)
    public static bool operator ==(Punto a, Punto b)
    {
        // Gestione null per sicurezza
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

        return a.x == b.x && a.y == b.y;
    }

    public static bool operator !=(Punto a, Punto b)
    {
        return !(a == b);
    }

    // Overload > e < (confronto su distanza^2 dall'origine, evita radici)
    public static bool operator >(Punto a, Punto b)
    {
        return a.DistanzaQuadrata() > b.DistanzaQuadrata();
    }

    public static bool operator <(Punto a, Punto b)
    {
        return a.DistanzaQuadrata() < b.DistanzaQuadrata();
    }

    // Metodo di supporto (non serve Math.Sqrt)
    private int DistanzaQuadrata()
    {
        return x * x + y * y;
    }

    // Quando si overloada == conviene anche fare override di Equals/GetHashCode
    // (qui lo facciamo semplice per coerenza didattica)
    public override bool Equals(object obj)
    {
        Punto other = obj as Punto;
        if (other == null) return false;
        return x == other.x && y == other.y;
    }

    public override int GetHashCode()
    {
        return x.GetHashCode() ^ y.GetHashCode();
    }
}
