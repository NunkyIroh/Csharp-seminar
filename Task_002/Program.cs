// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// 10 мин

int a = 2;
int b = 10;
int square = (b * b);
if (square == a)
{
    Console.WriteLine($"b является квадратом a");
}
else
{
    Console.WriteLine($"b не является квадратом a");
}

//belov.max7@yandex.ru надо будет и нашу первую переделать

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// switch (num)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Четверг"); break;
//     case 5: Console.WriteLine("Пятница"); break;
//     case 6: Console.WriteLine("Суббота"); break;
//     case 7: Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Нет такого дня недели"); break;
// }
// // Console.ReadKey();