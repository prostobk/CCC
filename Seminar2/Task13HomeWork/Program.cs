﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
    number /= 10;
}
Console.WriteLine(number % 10);
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}