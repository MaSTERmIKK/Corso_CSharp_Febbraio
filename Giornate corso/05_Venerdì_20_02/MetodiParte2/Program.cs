class Program
{
    public static void Main(string[] args)
    {
        //=============== OVERLOAD =====================
        /* Stampa("Ciao");
        // Stampa(10);
        // Stampa(10, "Ciao");
        // Console.WriteLine($"il nuovo numero è {Stampa(10f)}");

        Console.WriteLine($"SommaInt = {Somma(10, 20)}");
        Console.WriteLine($"SommaFloat = {Somma(10.4f, 20.3f)}");*/
        
        //================ REF =========================
        /*int n = 0;
        if(IncrementaEControlla(ref n))
        {
            Console.WriteLine($"pari");
        }
        else
        {
            Console.WriteLine($"dispari");
        }

        Console.WriteLine($"N = {n}");*/
    
        //================ OUT =========================
        /* int numero;
        // Calcolo(out numero);
        // Console.WriteLine($"Numero = {numero}");

        // float perimetroTriangolo;
        // float areaTriangolo;
        // DescriviTriangoloEquilatero(3, 5, out perimetroTriangolo, out areaTriangolo);
        // Console.WriteLine($"Il triangolo di l 3 e a 5 ha perimetro {perimetroTriangolo} e area {areaTriangolo}");

        // string nStringa= "26";
        // int strConvertita;
        // if(int.TryParse(nStringa, out strConvertita))
        // {
        //     Console.WriteLine($"Conversione Riuscita con successo. {nStringa} è {strConvertita}");
        // }
        // else
        // {
        //     Console.WriteLine($"Conversione Fallita");
        // }*/
    }

#region Overload Methods
    static void Stampa(int numero)
    {
        Console.WriteLine($"il numero è {numero}");
    }

    static void Stampa(string messaggio)
    {
        Console.WriteLine($"il messaggio è {messaggio}");
    }

    static void Stampa(int numero, string messaggio)
    {
        Console.WriteLine($"il numero è {numero} e il messaggio è {messaggio}");
    }

    static float Stampa(float numero)
    {
        Console.WriteLine($"il numero è {numero}");
        return numero + 10;
    }


    static int Somma(int a, int b)
    {
        return a + b;
    }

    static float Somma(float a, float b)
    {
        return a + b;
    }

#endregion

#region REF Methods
    public static bool IncrementaEControlla(ref int numero)
    {
        numero++;
        return numero % 2 == 0;
    }

    public static int Incrementa(int numero)
    {
        return numero++;
    }
#endregion

#region OUT Methods
    private static void Calcolo(out int risultato)
    {
        risultato = 10;
    }

    private static void DescriviTriangoloEquilatero(float l, float a, out float perimetro, out float area)
    {
        perimetro = l*3;
        area = l*a/2;
    }
#endregion
}
