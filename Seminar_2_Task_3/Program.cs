// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {rndNum}");

int firstDigit = rndNum / 100;
int secondDigit = rndNum % 10;

Console.WriteLine($"Цисло {firstDigit}{secondDigit}");