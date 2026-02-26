//Dichiarazione con inizializzazione
Dictionary<string, string> studenti = new Dictionary<string, string>()
{
    { "123abc", "Mario" },
    { "456def", "Luigi" }
};

// Aggiungere un elemento
studenti.Add("789ghi", "Franco");
studenti["101112lmn"] = "Paolo"; // alternativa con key

foreach(var stud in studenti)
{
    Console.WriteLine($"matricola: {stud.Key} nome: {stud.Value}");
}

Console.WriteLine($"\n");

// Accedere ad un valore
Console.WriteLine(studenti["123abc"]);
Console.WriteLine(studenti["101112lmn"]); 

Console.WriteLine($"\n");

// Verificare esistenza chiave o valore
Console.WriteLine($"la matricola 123abc esiste? {studenti.ContainsKey("123abc")}");
Console.WriteLine($"lo studente Luigi esiste? {studenti.ContainsValue("Luigi")}");

Console.WriteLine($"\n");

// Rimuovere un elemento
string key = "123abc";
if (studenti.Remove(key))
{
    Console.WriteLine($"Elemento di chiave {key} è stato rimosso. Contain Check: {studenti.ContainsKey(key)}");
}
else
{
    Console.WriteLine($"Elemento di chiave {key} NON è stato rimosso. Contain Check: {studenti.ContainsKey(key)}");
}

Console.WriteLine($"\n");

// Aggiornare un valore
string newKey = "234efg";
studenti[newKey] = "Giovanni";
Console.WriteLine($"Cambiato valore in chiave {newKey}. Check nuovo valore: {studenti[newKey]}");

Console.WriteLine($"\n");

//Accesso con indice numerico sequenziale
// Console.WriteLine($"{studenti.ElementAt(0)}");
// Console.WriteLine($"{studenti.ElementAt(1)}");
// Console.WriteLine($"{studenti.ElementAt(2)}");

for(int i = 0; i < studenti.Count; i++)
{
    Console.WriteLine($"Key: {studenti.ElementAt(i).Key}, Value: {studenti.ElementAt(i).Value}");
}

KeyValuePair<string, string> studente;
foreach(KeyValuePair<string, string> stud in studenti)
{
    Console.WriteLine($"num: {stud.Key} nome: {stud.Value}");
}

//Funzioni Extra
studenti.Last();
studenti.First();
