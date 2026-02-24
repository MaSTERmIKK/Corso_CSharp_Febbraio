int[,] matrice = new int[3,3];

int nRighe = matrice.GetLength(0); //3 - righe
int nColonne = matrice.GetLength(1); //3 - colonne

// Assegnazione valori matrice
for(int i = 0; i < nRighe; i++)
{
    for(int j = 0; j < nColonne; j++)
    {
        matrice[i, j] = (i + j + 1) * 10;
        Console.WriteLine($"Cella [{i}][{j}] = {matrice[i,j]}");
    }
}

Console.WriteLine("------------------ MATRICE INVERTITA --------------------");
for(int i = nRighe - 1; i >= 0; i--)
{
    for(int j = nColonne - 1; j >= 0; j--)
    {
        Console.WriteLine($"Cella [{i}][{j}] = {matrice[i,j]}");
    }
}

Console.WriteLine("------------------ DIAGONALI --------------------");
//Esplorazione Diagonali

// Prima Diagonale

int sommaDiagonale = 0;
for(int i = 0; i < nRighe; i++)
{
    for(int j = 0; j < nColonne; j++)
    {
        if(i == j)
        {
            sommaDiagonale += matrice[i, j];
        }
    }
}

Console.WriteLine($"\nSomma Diagonale 1: {sommaDiagonale}");


int sommaSecondaDiagonale = 0;
for(int i = 0; i < nRighe; i++)
{
    sommaSecondaDiagonale += matrice[i, nColonne - 1 - i];
}

Console.WriteLine($"\nSomma Diagonale 2: {sommaSecondaDiagonale}");

// // Riempimento Matrice con valori casuali interi
// Console.WriteLine("\n---------------- MATRICE INT RANDOM-----------------------");
// int[,] randomArray = new int[10, 15];
// Random random = new Random();

// for(int i = 0; i < randomArray.GetLength(0); i++)
// {
//     for(int j = 0; j < randomArray.GetLength(1); j++)
//     {
//         randomArray[i, j] = random.Next(150, 412);
//         Console.WriteLine($"RandomArray Cella[{i},{j}] = {randomArray[i, j]}");
//     }
// }

// // Riempimento Matrice con valori casuali double
// Console.WriteLine("\n---------------- MATRICE DOUBLE RANDOM-----------------------");
// double[,] randomArrayDouble = new double[10, 15];

// int min = 10, max = 100;

// for(int i = 0; i < randomArrayDouble.GetLength(0); i++)
// {
//     for(int j = 0; j < randomArrayDouble.GetLength(1); j++)
//     {
//         randomArrayDouble[i, j] = random.NextDouble() * (max - min) + min;
//         Console.WriteLine($"RandomArrayDouble Cella[{i},{j}] = {randomArrayDouble[i, j]:F2}");
//     }
// }