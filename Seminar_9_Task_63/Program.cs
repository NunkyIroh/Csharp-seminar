// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("Задайте число: ");
int num = int.Parse(Console.ReadLine());

void NaturalNumber (int number)
{
    if(number == 0) return;
    // Console.Write($"{number} ");  если надо запасать наоборот
    NaturalNumber(number - 1);
    Console.Write($"{number} ");
}

NaturalNumber(num); 