// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Задайте первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте второе число: ");
int num2 = int.Parse(Console.ReadLine());

void NaturalNumber(int number1, int number2)
{
	if (number1 < number2)
	{
		Console.Write($"{number1} ");
		NaturalNumber(number1 + 1, number2);
		
	}
	
	if (number1 > number2)
	{
		Console.Write($"{number1} ");
		NaturalNumber(number1 - 1, number2);
		
	}
	if(number1==number2)
	Console.Write($"{number2}");
}

// void NumbersMN(int m, int n)
// {
//     if (m <= n)
//     {
//         Console.Write($"{m} ");
//         if (m == n) return;
//         NumbersMN(m + 1, n);
//     }
//     else if (m > n)
//     {
//         Console.Write($"{m} ");
//         if (m == n) return;
//         NumbersMN(m - 1, n);
//     }
// }

NaturalNumber(num1, num2);