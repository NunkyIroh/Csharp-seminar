// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

Console.WriteLine("Чтобы возвести число А в натуральную степень В:");
Console.Write("1. Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Введите натуральную степень В: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;

int NatDegree (int number, int degree)
{
    if (degree == 0) return 1;
    return number * NatDegree(number, degree-1);
}

// int NatDegree (int number, int degree)
// {
//     int result = 1;
//     for (int i = 1; i <= degree; i++)
//     {
//         result = result * number;
//     }
//     return result;
// }

void PrintDegree (int Exp)
{
    Console.Write($"Результат возведения числа А {A} в степень {B} равен {Exp}!");
}

int res = NatDegree(A, B);
PrintDegree(res);