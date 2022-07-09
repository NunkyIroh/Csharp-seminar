// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

Console.WriteLine("Чтобы создать массив следуйте инструкциям!");

Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

int[] CreateArrayRndInt(int sizeArray, int minimal, int maximum)
{
    int[] array = new int[sizeArray];
    Random rnd = new Random();

    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = rnd.Next(minimal, maximum + 1);
    }
    return array;
}

int[] GetResultArray(int[] array)
{
    int firstArryLength;
    if (array.Length % 2 == 0)
    {
        firstArryLength = array.Length / 2;
    }

    else
    {
        firstArryLength = (array.Length - 1) / 2 + 1;
    }

    var firstArray = new int[firstArryLength];
    for (int i = 0; i <firstArryLength; i++)
    {
        firstArray[i] = array[i];
    }
    var secondArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length/2; i++)
    {
        secondArray[i] = array[array.Length - i - 1];
    }

    var resultArray = new int[firstArryLength];
    for (int i = 0; i < secondArray.Length; i++)
    {
        resultArray[i] = firstArray[i] * secondArray[i];
    }

    if (firstArryLength != secondArray.Length)
    {
        resultArray[firstArryLength - 1] = firstArray[firstArryLength - 1];
    }

    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");

    }
}

int[] array = CreateArrayRndInt(sizeArr, min, max);
PrintArray(array);
var resultArray = GetResultArray(array);
PrintArray(resultArray);
