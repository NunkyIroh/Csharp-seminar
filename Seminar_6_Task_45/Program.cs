// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] CopyArray(int[] array)
{
    int sizeArray = array.Length;
    int[] newArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        newArray[i]= array[i];
    }
    return newArray;
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
Console.WriteLine();
var resultArray = CopyArray(array);
PrintArray(resultArray);