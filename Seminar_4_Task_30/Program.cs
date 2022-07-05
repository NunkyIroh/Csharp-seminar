// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите N: ");
int num = int.Parse(Console.ReadLine());

int[] FillArray(int num)
{
    int[] array = new int[num];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
    return array;
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write("]");
}

int[] arr = FillArray(num);
PrintArray(arr);

// int[] array = new int[8];
// Random rand = new Random();
// Console.Write("[");
// for (int i = 0; i < 8; i++)
// {
//     array[i] = rand.Next(0, 2);
//     Console.Write(array[i] + ",");
// }
// Console.Write("]");