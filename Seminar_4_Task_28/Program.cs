// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());

int Sum (int number)
{

    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
    sum = sum * i;
    }
    return sum;

}

int result = Sum(num);
Console.WriteLine($"Произведение чисел от 1 до N: {result}");