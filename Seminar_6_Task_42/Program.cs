// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Вариант через рекурсию
// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// int TenToTwo(int number)
// {
//     if (number == 1) return 1;
//     if (number == 0) return 0;
//     return number % 2 + 10 * TenToTwo(number / 2);
// }


// Вариант через цикл while
// Console.WriteLine(TenToTwo(A));

// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// Console.Write("Введите основание системы счисления: ");
// int baseNum = int.Parse(Console.ReadLine());

// int d10 = 1;
// int result = 0;
// while (number != 0)
// {
//     result = result + number % baseNum * d10;
//     number = number / baseNum;
//     d10 = d10 * 10;
// }
// Console.WriteLine(result);

// Вариант через рекурсию стеками
int a = 13;
void ToBin(int n)
{
    if (n == 0) return;
    ToBin(n / 2);
    Console.Write(n % 2);
}
ToBin(a);

// int a = 13;
// void ToBin(int n, int baseNum)
// {
//     if (n == 0) return;
//     ToBin(n / baseNum, baseNum);
//     Console.Write(n % baseNum);
// }
// ToBin(a, 2);