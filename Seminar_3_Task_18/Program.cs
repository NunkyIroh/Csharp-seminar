// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string Quarter(int number)
{
    if (number ==1) return "x - положительный, y - положительный";
    if (number ==2) return "x - отрицательный, y - положительный";
    if (number ==3) return "x - отрицательный, y - отрицательный";
    if (number ==4) return "x - положительный, y - отрицательный";
    return "Введены некорректные данные!";
}

string result = Quarter (num);
Console.WriteLine(result);

// Console.WriteLine("Введите номер четверти от 1 до 4");
// int x = Convert.ToInt32(Console.ReadLine());
// switch (x)
// {
//     case 1: Console.WriteLine("x > 0 и y > 0"); break;
//     case 2: Console.WriteLine("x < 0 и y > 0"); break;
//     case 3: Console.WriteLine("x < 0 и y < 0"); break;
//     case 4: Console.WriteLine("x > 0 и y < 0"); break;
//     default: Console.WriteLine("Нет такой четверти"); break;
// }