// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.Clear();

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m,n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(min, max + 1);
        }
        
    }
    return arr;
}

// int[,] MatrixEvenElement(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i+2)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j+2)
//         {
//         inArray[i,j] = inArray[i,j] * inArray[i,j];
//         }
//     }
//     return inArray;
// }

int[,] MatrixEvenElement(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) 
            {
                inArray[i,j] = inArray[i,j] * inArray[i,j];
            }
        }
    }
    return inArray;
}

void PrintMatrix (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        if (j==0) Console.Write("|");
        if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} |");
        else Console.Write($"{arr[i, j], 3} |");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt (3, 4, 8, 10);
PrintMatrix (arrayResult);
Console.WriteLine();
arrayResult = MatrixEvenElement(arrayResult);
PrintMatrix (arrayResult);