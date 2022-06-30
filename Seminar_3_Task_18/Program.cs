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