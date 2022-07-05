// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int Count(int number)
{
    int result = 0;
    {
        while (number > 0)
        {
            number = number / 10;
            result++;
        }
    }
    return result;
}
int countNum = Count(num);
Console.WriteLine($"Количество цифр в числе {num} = {countNum}");