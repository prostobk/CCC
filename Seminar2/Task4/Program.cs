// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
//  8,9  ->  нет

Console.WriteLine("Введите первое число: ");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? numberStringTwo = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if (numberIntTwo * numberIntTwo == numberIntOne || numberIntOne * numberIntOne == numberIntTwo)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}