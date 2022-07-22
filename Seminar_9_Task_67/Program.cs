// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

Console.WriteLine("Чтобы получить сумму цифр в числе:");
Console.Write("введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumNum(int number)
{
    if (number == 0) return 0;
    return number % 10 + SumNum(number / 10);
}

// int SumNum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     }
//     return sum;
// }

void PrintSumNum(int result)
{
    Console.Write($"Сумма цифр в числе N {N} равна: {result}!");
}

int res = SumNum(N);
PrintSumNum(res);