class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Il risultato della somma tra 10 e 30 è {Somma(10,30)}");
        Console.WriteLine($"Il risultato della somma tra 15 e 180 è {Somma(15,180)}");
        Console.WriteLine($"Il risultato della somma tra 11505 e 11286 è {Somma(11505,11286)}");

        int somma = 0;
        somma = Somma(12, 89);
        Console.WriteLine($"\nLa somma tra 12 e 89 è {somma}");

        int numero1 = 178;
        int numero2 = 123;
        somma = Somma(numero1, numero2);
        Console.WriteLine($"\nLa somma tra {numero1} e {numero2} è {somma}");

        Saluta("Edoardo");

        ConfrontaNumero();
    }

    //=============== METODO CON TIPO DI RITORNO ===============
    public static int Somma(int a, int b)
    {
        int risultato = a + b;
        return risultato;
    }

    //=============== METODO VOID ===============
    public static void Saluta(string nome)
    {
        Console.WriteLine($"Buongiorno {nome}, come va?");
    }

    //=============== SCOPE ===============
    static int x = 5;
    public static void ConfrontaNumero()
    {
        int y = 10;
        if(x > y)
        {
            int z = 6;
            Console.WriteLine($"{x} è maggiore di {y} e z è uguale a {z}");
        }
        else
        {
            Console.WriteLine($"{x} è minore di {y}");
        }

        // Console.WriteLine($"{z}");
    }
}