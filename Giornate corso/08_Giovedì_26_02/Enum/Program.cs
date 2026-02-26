public enum Prodotto
{
    Gelato, //0
    Olio,  // 1
    Mele   //2
}

class Programm
{
    public enum Semaforo
    {
        Rosso,
        Giallo,
        Verde
    }
    public static void Main(string[] args)
    {
        // Console.WriteLine($"Prodotto 1: {Prodotto.Gelato}");

        // Prodotto prod = Prodotto.Gelato;

        // switch (prod)
        // {
        //     case Prodotto.Gelato:
        //         break;
        //     case Prodotto.Mele:
        //         break;
        //     case Prodotto.Olio:
        //         break;
        //     default:
        //         break;
        // }

        List<Semaforo> semafori = new List<Semaforo>();

        semafori.Add(Semaforo.Rosso);
        semafori.Add(Semaforo.Rosso);
        semafori.Add(Semaforo.Verde);
    }
}

