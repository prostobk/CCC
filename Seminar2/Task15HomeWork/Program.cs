// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число: ");
string? numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString);

if (numberInt == 1)
{
    Console.WriteLine("Нет");
}
if (numberInt == 2)
{
    Console.WriteLine("Нет");
}
if (numberInt == 3)
{
    Console.WriteLine("Нет");
}
if (numberInt == 4)
{
    Console.WriteLine("Нет");
}
if (numberInt == 5)
{
    Console.WriteLine("Нет");
}
if (numberInt == 6)
{
    Console.WriteLine("Да");
}
if (numberInt == 7)
{
    Console.WriteLine("Да");
}
if (numberInt > 7 || numberInt < 1)
{
    Console.WriteLine("Такого дня нет");
}