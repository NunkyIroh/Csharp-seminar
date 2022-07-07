// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] CoupArray (int[] arr)
{
    int[] negArr = arr;
    for (int i = 0; i < arr.Length; i++)
    {
        negArr[i]=-arr[i];
    }
    return negArr;
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
int [] coupedArray = CoupArray (array);
PrintArray(coupedArray);