// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();
Console.WriteLine("Введите координаты точки: ");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверьть.");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверьть.");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверьть.");
// else if (x > 0 && y < 0) Console.WriteLine("четвертая четверьть.");
// else Console.WriteLine("Введены некорректные данные!");

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверьть.";
    if (xc< 0 && yc > 0) return "Вторая четверьть.";
    if (xc < 0 && yc < 0) return "Третья четверьть.";
    if (xc > 0 && yc < 0) return "четвертая четверьть.";
    return "Введены некорректные данные!";
}

string result = Quarter (x, y);
Console.WriteLine(result);