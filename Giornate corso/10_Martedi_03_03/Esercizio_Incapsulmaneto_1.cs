using System;

public class Libro
{
    // Proprietà pubbliche
    public string Titolo { get; set; }
    public string Autore { get; set; }
    public int AnnoPubblicazione { get; set; }

    // Costruttore comodo
    public Libro(string titolo, string autore, int annoPubblicazione)
    {
        Titolo = titolo;
        Autore = autore;
        AnnoPubblicazione = annoPubblicazione;
    }

    // 1) ToString: "Titolo" di Autore (Anno)
    public override string ToString()
    {
        return $"\"{Titolo}\" di {Autore} ({AnnoPubblicazione})";
    }

    // 2) Equals: uguali se stesso titolo e stesso autore
    public override bool Equals(object obj)
    {
        // Se non è un Libro -> false
        if (obj == null || !(obj is Libro))
            return false;

        Libro altro = (Libro)obj;

        // Confronto per Titolo e Autore (anno NON conta per l'uguaglianza richiesta)
        return Titolo == altro.Titolo && Autore == altro.Autore;
    }

    // 3) GetHashCode coerente con Equals (usa Titolo + Autore)
    public override int GetHashCode()
    {
        return HashCode.Combine(Titolo, Autore);
    }
}

class Program
{
    static void Main()
    {
        // 4) Creo due oggetti Libro con gli stessi valori
        Libro libro1 = new Libro("Il Signore degli Anelli", "J.R.R. Tolkien", 1954);
        Libro libro2 = new Libro("Il Signore degli Anelli", "J.R.R. Tolkien", 1954);

        // Verifica ToString
        Console.WriteLine("ToString libro1: " + libro1.ToString());
        Console.WriteLine("ToString libro2: " + libro2.ToString());

        // Verifica Equals -> deve essere true
        Console.WriteLine("Equals: " + libro1.Equals(libro2));

        // Verifica GetHashCode -> devono essere uguali
        Console.WriteLine("HashCode libro1: " + libro1.GetHashCode());
        Console.WriteLine("HashCode libro2: " + libro2.GetHashCode());
        Console.WriteLine("HashCode uguali? " + (libro1.GetHashCode() == libro2.GetHashCode()));
    }
}
