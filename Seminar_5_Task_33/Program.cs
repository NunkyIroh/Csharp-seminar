// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите длинну массива: ");
int sizeArr = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int minimal = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int maximum = int.Parse(Console.ReadLine());

Console.Write("Введите искомое значение: ");
int num = int.Parse(Console.ReadLine());


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

void numArray (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        {
            Console.WriteLine("yes");
            return;
        }
    }
    Console.WriteLine("No");
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

int[] array = CreateArrayRndInt (sizeArr, minimal, maximum);
PrintArray (array);
numArray (array, num);
