// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
else
{
    int num1 = number / 10;
    int num2 = num1 % 10;
    Console.WriteLine(num2);
}