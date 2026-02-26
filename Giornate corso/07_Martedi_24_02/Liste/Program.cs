List<string> parole = new List<string>();

// Add
parole.Add("Ciao");
parole.Add("Come");
parole.Add("va?");
parole.Add("Piccione");
parole.Add("Sabato");
parole.Add("Scrivania");

// Remove
if (parole.Remove("Ciao"))
{
    Console.WriteLine($"Rimosso elemento");
}
parole.RemoveRange(1, 2);

//Iterazione For e ForEach
List<string> paroleDaRimuovere = new List<string>();
foreach (string parola in parole)
{
    Console.WriteLine($"{parola}");
    if (parola == "Sabato")
    {
        // parole.Remove(parola);
        paroleDaRimuovere.Add(parola);
    }
}

foreach (string p in paroleDaRimuovere)
{
    parole.Remove(p);
}

Console.WriteLine("\n-----------------------------\n");

for (int i = 0; i < parole.Count; i++)
{
    Console.WriteLine($"{i}-{parole[i]}");
}

if (parole.Contains("Ciao"))
{
    Console.WriteLine($"Parole contiene Ciao");
    parole.Remove("Ciao");
}

//Clear

// parole.Clear();

// Console.WriteLine($"Count: {parole.Count}");


//insert
parole.Insert(1, "Gabibbo");

//IndexOf
parole.IndexOf("Ciao");

// To Array
string[] paroleArray = parole.ToArray();

foreach (string parola in parole)
{
    Console.WriteLine($"{parola}");
}

//Inizializzazione con valori
List<int> numeri = new List<int> { 20, 30, 40 };
numeri.Add(10);
numeri.Add(200);
numeri.Add(30);

Console.WriteLine("\n--- Numeri Ordinati ---");
var numeriOrdinati = numeri.OrderBy(n => n);
foreach (var n in numeriOrdinati)
{
    Console.WriteLine(n);
}
