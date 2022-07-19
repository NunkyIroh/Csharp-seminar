// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

Console.Clear();

void FillMatrixWithRandomIntValue(int[,] in_array, int in_minValue, int in_maxValue)
{
    var rndGenerator = new Random();
    for (int i = 0; i < in_array.GetLength(0); i++)
    {
        for (int j = 0; j < in_array.GetLength(1); j++)
        {
            in_array[i, j] = rndGenerator.Next(in_minValue, in_maxValue + 1);
        }
    }
}

void PrintMatrix(int[,] in_array)
{
    Console.WriteLine(@$"
    Массив размерности [{in_array.GetLength(0)},{in_array.GetLength(1)}] ↓
    ");
    for (int i = 0; i < in_array.GetLength(0); i++)
    {
        for (int j = 0; j < in_array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < in_array.GetLength(1) - 1) Console.Write($"| [{i}][{j}] = {in_array[i, j],4} |");
            else Console.Write($"| [{i}][{j}] = {in_array[i, j],4} ||");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] in_array)
{
    for (int i = 0; i < in_array.GetLength(0); i++)
    {
        if (i == 0) Console.Write("[");
        if (i < in_array.GetLength(0) - 1) Console.Write($" {in_array[i],4};");
        else Console.WriteLine($" {in_array[i],4} ]");
    }
}


int[] ConvertToOneDimensionArray(int[,] in_array)
{
    int[] arrayForMethod = new int[in_array.Length];
    int count = 0;
    Console.WriteLine($"in_array.Length = {in_array.Length}");
    Console.WriteLine($"in_array.GetLength(0) = {in_array.GetLength(0)}");
    Console.WriteLine($"in_array.GetLength(1) = {in_array.GetLength(1)}");
    for (int i = 0; i < in_array.GetLength(0); i++)
    {
        for (int j = 0; j < in_array.GetLength(1); j++)
        {
            arrayForMethod[count] = in_array[i, j];
            count++;
        }
    }
    return arrayForMethod;
}

int[] SummUniqValuesInArray(int[] in_array, int[] in_array2)
{
    int count = 0;
    int actualValue = in_array[0];
    int iForSecondArray = 0;
    for (int i = 0; i < in_array.Length; i++)
    {
        if (actualValue == in_array[i])
        {
            count++;
        }
        else
        {
            actualValue = in_array[i];
            in_array2[iForSecondArray] = count;
            count = 1;
            iForSecondArray++;
        }
        if (i == in_array.Length - 1)
        {
            in_array2[iForSecondArray] = count;
        }
    }
    return in_array2;
}

Console.Write("Введите количество строк в двумерном массиве m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в двумерном массиве n = ");
int n = int.Parse(Console.ReadLine());

int[,] arrayForTask = new int[m, n];
FillMatrixWithRandomIntValue(arrayForTask, 0, 40);
PrintMatrix(arrayForTask);

int[] arrayResul = ConvertToOneDimensionArray(arrayForTask);

Console.WriteLine("массив основной");
PrintArray(arrayResul);

Array.Sort(arrayResul);
int[] uniqArray = arrayResul.Distinct().ToArray();
Console.WriteLine("массив отсортированный");
PrintArray(uniqArray);

uniqArray = SummUniqValuesInArray(arrayResul, uniqArray);
Console.WriteLine("массив с количеством повторений");
PrintArray(uniqArray);

// Немного причесал вывод в консоль и код.