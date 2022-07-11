// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// // меньше суммы двух других сторон.

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

void Triangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
    {
        Console.WriteLine("yes");
    }
    else Console.WriteLine("No");
}

Triangle(A, B, C);


