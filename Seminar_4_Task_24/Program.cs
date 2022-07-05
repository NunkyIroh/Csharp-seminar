// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число А: ");
int num = int.Parse(Console.ReadLine());

// int sum = 0;

// for (int i = 1; i <= num; i++)
// {
//     sum += i;
//     // sum = sum + i;
// }

// Console.WriteLine($"Сумма чисел от 1 до А: {sum}");

int Sum (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int result = Sum(num);
Console.WriteLine($"Сумма чисел от 1 до А: {result}");