﻿Console.WriteLine("Введите первое число: ");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? numberStringTwo = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if (numberIntTwo * numberIntTwo == numberIntOne)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}