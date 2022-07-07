// Задача 31: 
// 1. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
// 3. Вывод результат.

Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int minimal = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int maximum = int.Parse(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] GetSumPosNegElem(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            // sumNeg = sumNeg + arr[i];
            sumNeg += arr[i];
        }
        else
        {
            sumPos += arr[i];
        }
    }
    return new int[]{sumPos, sumNeg};
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i==0) Console.Write("Массив [");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
        
    }
}

void PrintSumPosNegElem(int[] sum)
{
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных чисел равна {sum[0]}");
    Console.WriteLine($"Сумма отрицательных чисел равна {sum[1]}");
}

int[] array = CreateArrayRndInt (sizeArr, minimal, maximum);
PrintArray (array);
int [] sumPosNegElem = GetSumPosNegElem (array);
PrintSumPosNegElem(sumPosNegElem);