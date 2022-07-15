// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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

int MatrixSumDigonalNumbers(int[,] inArray)
{
    int sum =0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == j) 
            {
                sum = sum + inArray[i,j];
            }
        }
    }
    return sum;
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
Console.WriteLine(MatrixSumDigonalNumbers(arrayResult));
