// Ввод пользователького массива
// int[] data = Console.ReadLine().Split(';').Select(int.Parse).ToArray();

// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
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
