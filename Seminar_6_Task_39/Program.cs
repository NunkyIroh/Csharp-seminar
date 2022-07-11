// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int arr [] = new int[8];
// Array.Reverse(arr);

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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");

    }
}

void ReverseArray(int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int temp = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = temp;
        index1++;
        index2--;
    }
}

int[] array = CreateArrayRndInt(sizeArr, minimal, maximum);
PrintArray(array);
ReverseArray(array);
Console.WriteLine();
PrintArray(array);
Array.Reverse(array);
Console.WriteLine();
PrintArray(array);